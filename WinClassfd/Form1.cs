using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace WinClassfd
{
    public partial class frmMain : Form
    {
        // URL is http://<this ip>:8004/classfd.tle

        int secondsToWait = 11;
        DateTime startTime;
        Timer theTimer;
        SimpleHTTPServer theServer;
        const string classfdWebPath = @"https://www.prismnet.com/~mmccants/tles/classfd.zip";
        const string localPath = @"C:\users\erik\classfd";
        const string classfdFile = @"classfd.zip";
        const string localFullFilePath = localPath + @"\" + classfdFile;
        const int serverPort = 8004;

        public frmMain()
        {
            InitializeComponent();
            lblIPAddress.Left = (this.ClientSize.Width - lblIPAddress.Width) / 2;

            lblIPAddress.Text = Utils.GetLocalIPv4();
            theTimer = new Timer();
            theTimer.Interval = 1000;
            theTimer.Tick += theTimer_Tick;
            startTime = DateTime.Now;
            theTimer.Start();
        }

        void theTimer_Tick(object sender, EventArgs e)
        {
            int elapsedSeconds = (int)(DateTime.Now - startTime).TotalSeconds;
            int remainingSeconds = secondsToWait - elapsedSeconds;

            if (remainingSeconds < 6)
            {
                lblCountdown.ForeColor = Color.Red;
            }
            if (remainingSeconds <= 0)
            {
                ExitApp();
            }
            lblCountdown.Text = remainingSeconds.ToString();
        }

        private void UpdateProgress(string status)
        {
            txtStatus.AppendText(status + Environment.NewLine);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            theTimer.Stop();
            lblCountdown.Text = String.Empty;

            clearDirectory(localPath);
            getClassfdFile(classfdWebPath, localFullFilePath);
            unzipClassfd(localFullFilePath, localPath);
            theServer = new SimpleHTTPServer(localPath, serverPort, txtStatus);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void clearDirectory(string path)
        {
            UpdateProgress("Clearing " + path);
            DirectoryInfo di = new DirectoryInfo(path);
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            Console.WriteLine("done.");
        }

        private void getClassfdFile(string path, string filename)
        {
            UpdateProgress("Getting " + filename);
            WebClient wc = new WebClient();
            wc.DownloadFile(path, filename);
            //UpdateProgress("classfd last updated: " + File.GetCreationTime(filename).ToString());
        }

        private void unzipClassfd(string zipPath, string extractPath)
        {
            UpdateProgress("Unzipping " + zipPath);
            ZipFile.ExtractToDirectory(zipPath, extractPath);
            UpdateProgress("classfd.tle last updated: " + File.GetLastWriteTime(extractPath + @"\classfd.tle").ToString());
        }

        private void ExitApp()
        {
            theTimer.Stop();
            if (theServer != null)
            {
                theServer.Stop();
            }
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(700, 10);
        }
    }
}
