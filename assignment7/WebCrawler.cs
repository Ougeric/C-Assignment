using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

// WebCrawler 类核心逻辑
public class WebCrawler
{
    private readonly Uri _baseUri;
    private readonly HashSet<string> _visitedUrls = new HashSet<string>();
    private readonly Queue<string> _urlQueue = new Queue<string>();
    private readonly string[] _allowedExtensions = { ".htm", ".html", ".aspx", ".php", ".jsp" };

    public event Action<string> UrlCrawled;
    public event Action<string, string> UrlError;

    public WebCrawler(string startUrl)
    {
        _baseUri = new Uri(startUrl);
        _urlQueue.Enqueue(startUrl);
    }

    public void Start()
    {
        while (_urlQueue.Count > 0)
        {
            string currentUrl = _urlQueue.Dequeue();
            if (!IsSameDomain(currentUrl) || _visitedUrls.Contains(currentUrl)) continue;

            try
            {
                string html = DownloadHtml(currentUrl);
                _visitedUrls.Add(currentUrl);
                UrlCrawled?.Invoke(currentUrl);

                if (ShouldParseLinks(currentUrl))
                {
                    var links = ParseLinks(html, currentUrl);
                    foreach (var link in links)
                    {
                        _urlQueue.Enqueue(link);
                    }
                }
            }
            catch (Exception ex)
            {
                UrlError?.Invoke(currentUrl, ex.Message);
            }
        }
    }

    private string DownloadHtml(string url)
    {
        using (WebClient client = new WebClient())
        {
            return client.DownloadString(url);
        }
    }

    private IEnumerable<string> ParseLinks(string html, string baseUrl)
    {
        var regex = new Regex("<a\\s+(?:[^>]*?\\s+)?href=\"([^\"]*)\"");
        var matches = regex.Matches(html);
        foreach (Match match in matches)
        {
            string relativeUrl = match.Groups[1].Value;
            string absoluteUrl = ResolveAbsoluteUrl(baseUrl, relativeUrl);
            if (IsSameDomain(absoluteUrl))
            {
                yield return absoluteUrl;
            }
        }
    }

}