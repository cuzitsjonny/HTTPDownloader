using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace HTTPDownloader
{
    public partial class MainForm : Form
    {
        private const long ProgressUpdateInterval = 1000;

        private Color _DefaultTextFieldForeColor;
        private bool _IsSourceValid;
        private bool _IsDestinationValid;
        private long _UpdateTimestamp;

        public MainForm()
        {
            _IsSourceValid = false;
            _IsDestinationValid = false;

            InitializeComponent();

            _DefaultTextFieldForeColor = _SourceField.ForeColor;
        }

        private double CalculatePercentage(long part, long total)
        {
            return ((double)part / (double)total) * 100.0;
        }

        private long GetCurrentTimestamp()
        {
            return DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        }

        private bool CheckDownloadConditions()
        {
            return (_IsSourceValid && _IsDestinationValid);
        }
        private void UpdateProgress(double progress)
        {
            if(progress == 100.0)
            {
                _ProgressLabel.Text = "Progress\nCompleted";
            }
            else
            {
                _ProgressLabel.Text = "Progress\n" + progress.ToString("0.0000") + "%";
            }

            _ProgressBar.Value = (int)progress;

            _ProgressLabel.Update();
            _ProgressBar.Update();
        }

        private void _SourceField_TextChanged(object sender, EventArgs e)
        {
            try
            {
                new Uri(_SourceField.Text);

                _SourceField.ForeColor = _DefaultTextFieldForeColor;
                _IsSourceValid = true;
                _DownloadButton.Enabled = CheckDownloadConditions();
            }
            catch (Exception)
            {
                _SourceField.ForeColor = Color.Firebrick;
                _IsSourceValid = false;
            }
        }

        private void _DestinationField_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Path.GetFullPath(_DestinationField.Text);

                _DestinationField.ForeColor = _DefaultTextFieldForeColor;
                _IsDestinationValid = true;
                _DownloadButton.Enabled = CheckDownloadConditions();
            }
            catch (Exception)
            {
                _DestinationField.ForeColor = Color.Firebrick;
                _IsDestinationValid = false;
            }
        }

        private void _DestinationButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            DialogResult ofdResult;

            ofdResult = ofd.ShowDialog();

            if(ofdResult == DialogResult.OK)
            {
                _DestinationField.Text = ofd.FileName;
                _DestinationField.ForeColor = _DefaultTextFieldForeColor;
                _IsDestinationValid = true;
                _DownloadButton.Enabled = CheckDownloadConditions();
            }
        }

        private void _DownloadButton_Click(object sender, EventArgs e)
        {
            UpdateProgress(0.0);

            _SourceField.Enabled = false;
            _DestinationField.Enabled = false;
            _DestinationButton.Enabled = false;
            _DownloadButton.Enabled = false;
            _ProgressBar.Enabled = true;
            _UpdateTimestamp = GetCurrentTimestamp();

            WebClient client = new WebClient();

            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(OnDownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(OnDownloadFileCompleted);
            client.DownloadFileAsync(new Uri(_SourceField.Text), _DestinationField.Text);
        }

        private void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            long currentTimestamp = GetCurrentTimestamp();

            if ((currentTimestamp - _UpdateTimestamp) >= ProgressUpdateInterval)
            {
                double percentage = CalculatePercentage(e.BytesReceived, e.TotalBytesToReceive);

                UpdateProgress(percentage);

                _UpdateTimestamp = currentTimestamp;
            }
        }

        private void OnDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            UpdateProgress(100.0);

            _SourceField.Enabled = true;
            _DestinationField.Enabled = true;
            _DestinationButton.Enabled = true;
            _DownloadButton.Enabled = true;
            _ProgressBar.Enabled = false;
        }
    }
}
