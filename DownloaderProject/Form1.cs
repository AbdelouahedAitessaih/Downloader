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
using AltoHttp;

namespace DownloaderProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HttpDownloader httpDownloader;
        private void btnStart_Click(object sender, EventArgs e)
        {

            httpDownloader = new HttpDownloader(urlText.Text, $"{Application.StartupPath}\\{Path.GetFileName(urlText.Text)}");
            httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
            httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
            httpDownloader.Start();

        }

        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            progressBar.Value = (int)e.Progress;
            percentText.Text = $"{e.Progress.ToString("0.00")} %";
            speedText.Text = string.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
            downloadedText.Text = string.Format("{0} MB/s", (httpDownloader.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
            statusText.Text = "Downloading...";
        }

        private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                statusText.Text = "Finish !";
                percentText.Text = "100 %";
            });
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null)
                httpDownloader.Pause();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null)
                httpDownloader.Resume();
        }
    }
}
