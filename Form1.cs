using System.Text.RegularExpressions;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {
        YoutubeClient youtube = new YoutubeClient();
        string currentUrl = "";
        string currentTitle = "";

        public Form1()
        {
            InitializeComponent();

            downloadFormatBox.SelectedIndex = 0;
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

            if (downloadFormatBox.SelectedIndex == 0) // Audio Only
            {
                var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
                string title = Regex.Replace(currentTitle, @"[^\w\.@-]", "");
                await youtube.Videos.Streams.DownloadAsync(streamInfo, downloadPathTextBox.Text + @"\" + title + ".wav");
            }
            else if (downloadFormatBox.SelectedIndex == 1) // Video & Audio
            {
                var streamInfo = streamManifest.GetVideoStreams().GetWithHighestVideoQuality();
                var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
                //string title = string.Join("", currentTitle.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                string title = currentTitle;
                await youtube.Videos.Streams.DownloadAsync(streamInfo, downloadPathTextBox.Text + @"\" + title + $".{streamInfo.Container}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            downloadVideo();
        }

        private void downloadFormatBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}