using AngleSharp.Common;
using System.Diagnostics;
using System.Media;
using System.Text.RegularExpressions;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {
        const int AUDIO_QUALITY_LOW = 6;
        const int AUDIO_QUALITY_MEDIUM = 3;
        const int AUDIO_QUALITY_HIGH = 1;

        const int VIDEO_QUALITY_LOW = 1;
        const int VIDEO_QUALITY_MEDIUM = 1;
        const int VIDEO_QUALITY_HIGH = 2;

        YoutubeClient youtube = new YoutubeClient();
        string currentUrl = "";
        string currentTitle = "";

        public Form1()
        {
            InitializeComponent();

            downloadFormatBox.SelectedIndex = 0;
            downloadQualityBox.SelectedIndex = 2;
            downloadCompleteLabel.ForeColor = Color.FromArgb(0, downloadCompleteLabel.ForeColor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            downloadPathTextBox.Text = Settings1.Default.filePath;
            videoLinkTextBox.KeyDown += new KeyEventHandler(checkEnterKeyPress);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async Task loadVideoAsync()
        {
            string videoUrl = videoLinkTextBox.Text;
            var video = await youtube.Videos.GetAsync(videoUrl);
            videoTitleLabel.Text = video.Title;

            string thumbnailUrl = video.Thumbnails[0].Url;
            int index = thumbnailUrl.LastIndexOf("?");
            thumbnailUrl = thumbnailUrl.Substring(0, index);

            videoThumbnailPictureBox.LoadAsync(thumbnailUrl);

            currentUrl = videoUrl;
            currentTitle = video.Title;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await loadVideoAsync();
            downloadCompleteLabel.Visible = false;
        }

        private async void checkEnterKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                await loadVideoAsync();
            }
        }

        private async void downloadVideo()
        {
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(currentUrl);

            int quality;

            if (downloadFormatBox.SelectedIndex == 0) // Audio Only
            {
                if (downloadQualityBox.SelectedIndex == 0)
                    quality = AUDIO_QUALITY_LOW;
                else if (downloadQualityBox.SelectedIndex == 1)
                    quality = AUDIO_QUALITY_MEDIUM;
                else
                    quality = AUDIO_QUALITY_HIGH;

                var streamInfo = streamManifest.GetAudioOnlyStreams().GetItemByIndex(quality);
                var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
                string title = Regex.Replace(currentTitle, "[^a-zA-Z0-9_]+", " "); // Prevents invalid characters
                await youtube.Videos.Streams.DownloadAsync(streamInfo, downloadPathTextBox.Text + @"\" + title + ".wav");
            }
            else if (downloadFormatBox.SelectedIndex == 1) // Video & Audio
            {
                if (downloadQualityBox.SelectedIndex == 0)
                    quality = VIDEO_QUALITY_LOW;
                else if (downloadQualityBox.SelectedIndex == 1)
                    quality = VIDEO_QUALITY_MEDIUM;
                else
                    quality = VIDEO_QUALITY_HIGH;

                var streamInfo = streamManifest.GetMuxedStreams().GetItemByIndex(quality);
                var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
                string title = Regex.Replace(currentTitle, "[^a-zA-Z0-9_]+", " ");
                await youtube.Videos.Streams.DownloadAsync(streamInfo, downloadPathTextBox.Text + @"\" + title + $".mp4"); // $".{streamInfo.Container}
            }

            SystemSounds.Asterisk.Play();
            downloadCompleteLabel.Visible = true;
            Process.Start("explorer.exe", downloadPathTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            downloadVideo();
        }

        private void folderDialogButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            downloadPathTextBox.Text = folderBrowserDialog1.SelectedPath;
            Settings1.Default.filePath = downloadPathTextBox.Text;
            Settings1.Default.Save();
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Settings1.Default.filePath = downloadPathTextBox.Text;
        }

        private void downloadQualityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            downloadQualityBox.Enabled = false;
            downloadQualityBox.Enabled = true;
        }
    }
}