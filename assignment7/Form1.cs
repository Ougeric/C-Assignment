using System;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent(); 
    }

    private async void btnStart_Click(object sender, EventArgs e)
    {
        string startUrl = txtStartUrl.Text.Trim();
        if (string.IsNullOrEmpty(startUrl))
        {
            MessageBox.Show("请输入初始 URL！");
            return;
        }

        var crawler = new WebCrawler(startUrl);

        // 绑定事件
        crawler.UrlCrawled += (url) => {
            this.Invoke((Action)(() => lstCrawled.Items.Add(url)));
        };

        crawler.UrlError += (url, error) => {
            this.Invoke((Action)(() => lstErrors.Items.Add($"{url}: {error}")));
        };

        await Task.Run(() => crawler.Start());
    }
}