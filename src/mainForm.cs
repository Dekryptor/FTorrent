using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonoTorrent;
using MonoTorrent.Client;
using MonoTorrent.Client.Encryption;
using System.Net;
using MonoTorrent.Common;
using System.Threading;
using GlacialComponents.Controls;
using System.Diagnostics;
using FTorrent.Utils;
using FTorrent.Utils.Win32;
using MonoTorrent.BEncoding;
using System.IO;
using FTorrent.Controls;
using MonoTorrent.Client.Tracker;
using Microsoft.VisualBasic.ApplicationServices;

namespace FTorrent
{
    public partial class mainForm : Form
    {
        TorrentState lastState;
        List<TorrentFile> torrentFiles = new List<TorrentFile>();
        Thread updater;
        string[] filesFromArgs;

        public mainForm(string[] args)
        {
            InitializeComponent();
            updater = new Thread(() => updateTorrents());
            updater.Start();
            filesFromArgs = args;
        }

        void updateTorrents()
        {
            while (true)
            {
                try
                {
                    Invoke((MethodInvoker)delegate ()
                    {
                        int index = 0;
                        foreach (TorrentFile file in torrentFiles)
                        {
                            (torrentList.Items[index].SubItems[1].Control as FProgressBar).Value = (int)file.downloadProgress;
                            torrentList.Items[index].SubItems[2].Text = ((int)file.downloadSpeed / 1000).ToString() + "kB/s";
                            torrentList.Items[index].SubItems[3].Text = ((int)file.uploadSpeed / 1000).ToString() + "kB/s";
                            torrentList.Items[index].SubItems[4].Text = (Math.Round(file.size / 1048576, 2)).ToString() + "MB";
                            
                            if (file.torrentState == TorrentState.Downloading)
                            {
                                (torrentList.Items[index].SubItems[1].Control as FProgressBar).ProgressBarColor = Color.YellowGreen;
                                (torrentList.Items[index].SubItems[1].Control as FProgressBar).DisplayStyle = ProgressBarDisplayText.Percentage;
                            }
                            else if (file.torrentState == TorrentState.Paused)
                            {
                                (torrentList.Items[index].SubItems[1].Control as FProgressBar).ProgressBarColor = Color.Orange;
                                (torrentList.Items[index].SubItems[1].Control as FProgressBar).DisplayStyle = ProgressBarDisplayText.CustomText;
                                (torrentList.Items[index].SubItems[1].Control as FProgressBar).CustomText = "Paused";
                            }
                            else if (file.torrentState == TorrentState.Error || file.torrentState == TorrentState.Stopped)
                            {
                                (torrentList.Items[index].SubItems[1].Control as FProgressBar).ProgressBarColor = Color.Red;
                                (torrentList.Items[index].SubItems[1].Control as FProgressBar).DisplayStyle = ProgressBarDisplayText.CustomText;
                                (torrentList.Items[index].SubItems[1].Control as FProgressBar).CustomText = "Stopped";
                            }
                            else if (file.torrentState == TorrentState.Seeding)
                            {
                                if (!file.finishNotified)
                                {
                                    file.finishNotified = true;
                                    taskBarIcon.ShowBalloonTip(5000, "Download completed!", file.name + " downloaded successfully.", ToolTipIcon.Info);
                                }
                                (torrentList.Items[index].SubItems[1].Control as FProgressBar).ProgressBarColor = Color.Yellow;
                                (torrentList.Items[index].SubItems[1].Control as FProgressBar).DisplayStyle = ProgressBarDisplayText.CustomText;
                                (torrentList.Items[index].SubItems[1].Control as FProgressBar).CustomText = "Seeding...";
                            }

                            TimeSpan timeLeft = TimeSpan.FromSeconds(MathUtils.ETA(file.downloadedBytes, file.downloadSpeed, file.size));
                            torrentList.Items[index].SubItems[5].Text = timeLeft.ToString();
                            index++;
                        }

                        if (torrentList.SelectedItems.Count != 0)
                        {
                            torrentTabs.Enabled = true;
                            filesList.Items.Clear();
                            int selectedIndex = torrentList.Items.FindItemIndex((GLItem)torrentList.SelectedItems[0]);
                            foreach (MonoTorrent.Common.TorrentFile file in torrentFiles[selectedIndex].torrent.Files)
                            {
                                double fileLength = file.Length;
                                double downloaded = file.BytesDownloaded;
                                GLItem gl = filesList.Items.Add(file.Path);
                                FProgressBar bar = new FProgressBar();
                                gl.SubItems[1].Control = bar;
                                bar.Value = (int)((double)file.BytesDownloaded / (double)file.Length) * 100;
                            }

                            trackersList.Items.Clear();
                            foreach (TrackerTier tier in torrentFiles[selectedIndex].manager.TrackerManager)
                            {
                                foreach (Tracker t in tier.GetTrackers())
                                {
                                    GLItem item = trackersList.Items.Add(t.Uri.ToString());
                                    item.SubItems[1].Text = t.Status.ToString();
                                }
                            }

                            try
                            {
                                peersList.Items.Clear();
                                foreach (PeerId p in torrentFiles[selectedIndex].manager.GetPeers())
                                {
                                    GLItem item = peersList.Items.Add(p.Connection.Uri.ToString());
                                    item.SubItems[1].Text = ((int)p.Monitor.DownloadSpeed / 1024).ToString() + "kB/s";
                                    item.SubItems[2].Text = ((int)p.Monitor.UploadSpeed / 1024).ToString() + "kB/s";
                                }
                            }
                            catch { }

                            speedCounter.Series[0].Points.Add(torrentFiles[selectedIndex].manager.Monitor.DownloadSpeed / 1024);
                            speedCounter.Series[1].Points.Add(torrentFiles[selectedIndex].manager.Monitor.UploadSpeed / 1024);
                        }
                        else
                        {
                            torrentTabs.Enabled = false;
                        }

                        if (Args.args != null)
                        {
                            foreach (string argument in Args.args)
                            {
                                if (File.Exists(argument) && argument.EndsWith(".torrent"))
                                {
                                    using (addTorrent addTor = new addTorrent(argument))
                                    {
                                        addTor.ShowDialog();
                                        GLItem item;
                                        torrentFiles.Add(new TorrentFile(addTor.torrentPath, addTor.savePath, new IPEndPoint(IPAddress.Any, 6969)));
                                        item = torrentList.Items.Add(torrentFiles[torrentFiles.Count - 1].name);
                                        FProgressBar fbar = new FProgressBar();
                                        fbar.DisplayStyle = ProgressBarDisplayText.Percentage;
                                        item.SubItems[1].Control = fbar;
                                        torrentFiles[torrentList.Count - 1].Start();
                                        torrentList.Refresh();
                                    }
                                }
                            }
                            Args.args = null;
                        }
                        Refresh();
                    });
                }
                catch { }
                Thread.Sleep(1000);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (addTorrent addTor = new addTorrent())
            {
                addTor.ShowDialog();
                if (addTor.savePath != null && addTor.torrentPath != null)
                {
                    GLItem item;
                    torrentFiles.Add(new TorrentFile(addTor.torrentPath, addTor.savePath, new IPEndPoint(IPAddress.Any, 6969)));
                    item = torrentList.Items.Add(torrentFiles[torrentFiles.Count - 1].name);
                    FProgressBar fbar = new FProgressBar();
                    fbar.DisplayStyle = ProgressBarDisplayText.Percentage;
                    item.SubItems[1].Control = fbar;
                    torrentFiles[torrentList.Count - 1].Start();
                    torrentList.Refresh();
                }
            }
        }

        void Shutdown()
        {
            if (!Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fastresume")))
            {
                Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fastresume"));
            }
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\fastresume\fr.dat"))
            {
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\fastresume\fr.dat");
            }
            if (torrentFiles.Count != 0)
            {
                BEncodedDictionary fastResume = new BEncodedDictionary();
                for (int i = 0; i < torrentFiles.Count; i++)
                {
                    if (torrentFiles[i].downloadProgress > 0)
                    {
                        torrentFiles[i].Stop();
                        while (torrentFiles[i].torrentState != TorrentState.Stopped)
                        {
                            Thread.Sleep(250);
                        }

                        fastResume.Add(torrentFiles[i].torrent.InfoHash.ToHex(), torrentFiles[i].manager.SaveFastResume().Encode());

                        File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fastresume", Path.GetFileName(torrentFiles[i].path)) + ".dat", torrentFiles[i].savePath + Environment.NewLine + torrentFiles[i].path);
                        File.WriteAllBytes(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fastresume", Path.GetFileName(torrentFiles[i].path)) + ".dat.dht", torrentFiles[i].engine.DhtEngine.SaveNodes());
                    }
                }
                File.WriteAllBytes(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fastresume", "fr.dat"), fastResume.Encode());
            }

            Environment.Exit(0);
        }

        void LoadTorrents()
        {
            string fastResumePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fastresume", "fr.dat");
            string torrentsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fastresume");
            if (File.Exists(fastResumePath))
            {
                BEncodedDictionary fastResume;
                fastResume = BEncodedValue.Decode<BEncodedDictionary>(File.ReadAllBytes(fastResumePath));

                int index = 0;
                foreach (string file in Directory.GetFiles(torrentsPath))
                {
                    if (file.EndsWith(".torrent.dat"))
                    {
                        string[] lines = File.ReadAllLines(file);
                        torrentFiles.Add(new TorrentFile(lines[1], lines[0], new IPEndPoint(IPAddress.Any, 6969), file + ".dht"));
                        if (fastResume.ContainsKey(torrentFiles[index].torrent.InfoHash.ToHex()))
                            torrentFiles[index].manager.LoadFastResume(new FastResume((BEncodedDictionary)fastResume[torrentFiles[index].torrent.InfoHash.ToHex()]));
                        GLItem item;
                        item = torrentList.Items.Add(torrentFiles[index].name);
                        FProgressBar fbar = new FProgressBar();
                        fbar.DisplayStyle = ProgressBarDisplayText.Percentage;
                        item.SubItems[1].Control = fbar;
                        torrentFiles[index].Start();
                        index++;
                        this.Refresh();
                    }
                }
            }
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            UpdateSizes();
        }

        private void torrentList_Click(object sender, EventArgs e)
        {
            if (torrentList.SelectedItems.Count != 0)
            {
                int selectedIndex = torrentList.Items.FindItemIndex((GLItem)torrentList.SelectedItems[0]);
                torrentNameLbl.Text = "Name: " + torrentFiles[selectedIndex].name;
                torrentSizeLbl.Text = "Size: " + (Math.Round(torrentFiles[selectedIndex].size / 1048576, 2)).ToString() + "MB";
                torrentCommentLbl.Text = "Comment: " + torrentFiles[selectedIndex].comment;
                torrentPathLbl.Text = "Path: " + torrentFiles[selectedIndex].path;
                outPathLbl.Text = "Out path: " + torrentFiles[selectedIndex].savePath;

                torrentBar.Value = (int)torrentFiles[torrentList.Items.FindItemIndex((GLItem)torrentList.SelectedItems[0])].downloadProgress;
                torrentBar.PointToClient(torrentTabs.Location);

                filesList.Items.Clear();

                torrentTabs.Enabled = true;

                foreach (MonoTorrent.Common.TorrentFile file in torrentFiles[selectedIndex].torrent.Files)
                {
                    float fileLength = (float)Math.Round((double)file.Length / 1048576, 2);
                    float downloaded = (float)Math.Round((double)file.BytesDownloaded / 1048576, 2);
                    GLItem gl = filesList.Items.Add(file.Path);
                    FProgressBar bar = new FProgressBar();
                    gl.SubItems[1].Control = bar;
                    bar.Value = MathUtils.PercentageOf(downloaded, fileLength);
                }

                filesList.Refresh();

                UpdateSizes();
            }
        }

        void UpdateSizes()
        {
            stateLbl.Size = new Size(infoTab.Width, torrentNameLbl.Height);
            torrentBar.Size = new Size(this.Width - 40, torrentBar.Height);
        }

        private void Torrent_Opening(object sender, CancelEventArgs e)
        {
            if (torrentList.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void Torrent_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (GLItem item in torrentList.SelectedItems)
            {
                int currentIndex = torrentList.Items.FindItemIndex(item);
                if (e.ClickedItem.Text == "Pause")
                {
                    e.ClickedItem.Text = "Resume";
                    torrentFiles[currentIndex].Pause();
                }
                else if (e.ClickedItem.Text == "Resume")
                {
                    e.ClickedItem.Text = "Pause";
                    torrentFiles[currentIndex].Start();
                }
                else if (e.ClickedItem.Text == "Stop")
                {
                    torrentFiles[currentIndex].Stop();
                    Torrent.Items[0].Text = "Resume";
                }
            }
        }

        private void torrentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int currentIndex = torrentList.Items.FindItemIndex((GLItem)torrentList.SelectedItems[0]);
            torrentFiles[currentIndex].Dispose();
            torrentList.Items.RemoveAt(currentIndex);
            torrentFiles.RemoveAt(currentIndex);

            ClearValues();
        }

        void ClearValues()
        {
            torrentNameLbl.Text = "Name: -";
            torrentSizeLbl.Text = "Size: -";
            torrentCommentLbl.Text = "Comment: -";
            torrentPathLbl.Text = "Path: -";
            outPathLbl.Text = "Out path: -";
            torrentBar.Value = 0;
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            taskBarIcon.Visible = true;
            this.Hide();
            //Shutdown();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            LoadTorrents();

            if (filesFromArgs != null)
            {
                foreach (string argument in filesFromArgs)
                {
                    if (File.Exists(argument) && argument.EndsWith(".torrent"))
                    {
                        using (addTorrent addTor = new addTorrent(argument))
                        {
                            addTor.ShowDialog();
                            GLItem item;
                            torrentFiles.Add(new TorrentFile(addTor.torrentPath, addTor.savePath, new IPEndPoint(IPAddress.Any, 6969)));
                            item = torrentList.Items.Add(torrentFiles[torrentFiles.Count - 1].name);
                            FProgressBar fbar = new FProgressBar();
                            fbar.DisplayStyle = ProgressBarDisplayText.Percentage;
                            item.SubItems[1].Control = fbar;
                            torrentFiles[torrentList.Count - 1].Start();
                            torrentList.Refresh();
                        }
                    }
                }
            }
        }

        private void maximumDownload_ValueChanged(object sender, EventArgs e)
        {
            int selectedIndex = torrentList.Items.FindItemIndex((GLItem)torrentList.SelectedItems[0]);
            torrentFiles[selectedIndex].engine.Settings.GlobalMaxDownloadSpeed = (int)maximumDownload.Value * 1000;
        }

        private void maxUpload_ValueChanged(object sender, EventArgs e)
        {
            int selectedIndex = torrentList.Items.FindItemIndex((GLItem)torrentList.SelectedItems[0]);
            torrentFiles[selectedIndex].engine.Settings.GlobalMaxUploadSpeed = (int)maxUpload.Value * 1000;
        }

        private void maxConnections_ValueChanged(object sender, EventArgs e)
        {
            int selectedIndex = torrentList.Items.FindItemIndex((GLItem)torrentList.SelectedItems[0]);
            torrentFiles[selectedIndex].engine.Settings.GlobalMaxConnections = (int)maxConnections.Value;
        }

        private void preferEncyptionBox_CheckedChanged(object sender, EventArgs e)
        {
            int selectedIndex = torrentList.Items.FindItemIndex((GLItem)torrentList.SelectedItems[0]);
            torrentFiles[selectedIndex].engine.Settings.PreferEncryption = preferEncyptionBox.Checked;
        }

        private void dhtBox_CheckedChanged(object sender, EventArgs e)
        {
            int selectedIndex = torrentList.Items.FindItemIndex((GLItem)torrentList.SelectedItems[0]);
            if (dhtBox.Checked)
                torrentFiles[selectedIndex].dhtListener.Start();
            else
                torrentFiles[selectedIndex].dhtListener.Stop();
        }

        private void torrentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taskBarIcon.Visible = false;
            this.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult msgBox = MessageBox.Show("Are you sure?", "FTorrent", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgBox == DialogResult.Yes)
            {
                Shutdown();
            }
        }
    }
}
