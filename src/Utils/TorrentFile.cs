using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoTorrent;
using MonoTorrent.Client;
using MonoTorrent.Client.Encryption;
using System.Net;
using MonoTorrent.Common;
using GlacialComponents.Controls;
using MonoTorrent.Dht.Listeners;
using MonoTorrent.Dht;
using System.IO;

namespace FTorrent
{
    public class TorrentFile : IDisposable
    {
        public string path;
        public string savePath;

        public EngineSettings settings;
        public ClientEngine engine;
        public Torrent torrent;
        public TorrentManager manager;
        public DhtListener dhtListener;
        public DhtEngine dhtEngine;

        public int maxDownload;
        public int minDownload;

        public double downloadProgress { get { return manager.Progress; } }
        public double downloadSpeed { get { return engine.TotalDownloadSpeed; } }
        public double uploadSpeed { get { return engine.TotalUploadSpeed; } }
        public double size { get { return torrent.Size;  } }
        public string name { get { return torrent.Name; } }
        public string comment { get { return torrent.Comment; } }
        public TorrentState torrentState { get { return manager.State; } }
        public double downloadedBytes { get { return manager.Monitor.DataBytesDownloaded; } }

        public bool finishNotified = false;
        
        public TorrentFile(string pathToTorrent, string outPath, IPEndPoint endPoint, string dhtNodeFile = null, bool DHTenabled = true, bool preferEncryption = true, EncryptionTypes encryption = EncryptionTypes.All)
        {
            path = pathToTorrent;
            savePath = outPath;

            settings = new EngineSettings();

            settings.AllowedEncryption = encryption;
            settings.PreferEncryption = preferEncryption;
            settings.SavePath = outPath;

            engine = new ClientEngine(settings);

            engine.ChangeListenEndpoint(endPoint);

            torrent = Torrent.Load(pathToTorrent);

            manager = new TorrentManager(torrent, outPath, new TorrentSettings());

            engine.Register(manager);

            byte[] nodes = null;
            try
            {
                nodes = File.ReadAllBytes(dhtNodeFile);
            }
            catch
            {

            }

            if (DHTenabled)
            {
                dhtListener = new DhtListener(endPoint);
                dhtEngine = new DhtEngine(dhtListener);
                engine.RegisterDht(dhtEngine);
                dhtListener.Start();
                engine.DhtEngine.Start(nodes);
            }
        }

        public void Start()
        {
            manager.Start();
        }

        public void Pause()
        {
            manager.Pause();
        }

        public void Stop()
        {
            manager.Stop();
        }

        public void Dispose()
        {
            engine.Dispose();
            manager.Dispose();
        }
    }
}
