using RssReader.WebClientWrapper.Abstract;
using System;
using System.Net;

namespace RssReader.WebClientWrapper
{
    public class RssReaderWebClient : IWebClientWrapper
    {
        private readonly WebClient webClient;

        public RssReaderWebClient(WebClient webClient)
        {
            this.webClient = webClient;
        }

        public string DownloadString(string RSSURL)
        {
            return this.webClient.DownloadString(RSSURL);
        }
    }
}