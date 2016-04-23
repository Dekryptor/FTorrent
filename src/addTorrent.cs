using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTorrent
{
    public partial class addTorrent : Form
    {
        public string torrentPath;
        public string savePath;

        public addTorrent(string torPath = null)
        {
            InitializeComponent();
            if (torPath != null)
            {
                torrentPath = torPath;
                torrentPathTxt.Text = torPath;
            }
        }

        private void browseTorrentBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Torrent files (*.torrent)|*.torrent";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                torrentPath = dialog.FileName;
                torrentPathTxt.Text = dialog.FileName;
            }
        }

        private void browseOutPathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                savePath = folderDialog.SelectedPath;
                savePathTxt.Text = folderDialog.SelectedPath;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            savePath = savePathTxt.Text;
            if (savePathTxt.Text != null && torrentPathTxt.Text != null)
            {
                if (File.Exists(torrentPath))
                {
                    if (Directory.Exists(savePathTxt.Text))
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Selected folder does not exists.", "FTorrent");
                    }
                }
                else
                {
                    MessageBox.Show("Selected torrent does not exists.", "FTorrent");
                }
            }
            else
            {
                MessageBox.Show("One or more values are null.", "FTorrent");
            }
        }
    }
}
