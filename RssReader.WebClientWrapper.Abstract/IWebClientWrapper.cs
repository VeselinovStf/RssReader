using System;

namespace RssReader.WebClientWrapper.Abstract
{
    public interface IWebClientWrapper
    {
        string DownloadString(string RSSURL);
    }
}