﻿using RssReader.Abstract;
using RssReader.Model.Abstract;
using RssReader.ModelFactory.Abstract;
using RssReader.Models.Implementations;
using RssReader.WebClientWrapper.Abstract;
using RssReader.XDocumentWrapper.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RssReader.Repositories
{
    public class RssFeedRepository : IRssReaderRepository<IRssFeed>
    {
        private readonly IWebClientWrapper webClient;
        private readonly IXDocumentParseWrapper xDocument;
        private readonly IRssReaderModelFactory<BaseRssFeed> rssFeedModelFactory;
        private readonly IRssReaderFeed feedDb;

        public RssFeedRepository(
            IWebClientWrapper webClient,
            IXDocumentParseWrapper xDocument,
            IRssReaderModelFactory<BaseRssFeed> rssFeedModelFactory,
            IRssReaderFeed feedDb)
        {
            this.webClient = webClient;
            this.xDocument = xDocument;
            this.rssFeedModelFactory = rssFeedModelFactory;
            this.feedDb = feedDb;
        }

        public IEnumerable<IEnumerable<IRssFeed>> GetListedFeed(string descendantElementName)
        {
            var rssFeed = this.feedDb.GetFeed();

            var RSSFeedData = new List<List<BaseRssFeed>>();

            foreach (var feed in rssFeed)
            {
                var RSSData = this.webClient.DownloadString(feed.URL);

                var xml = this.xDocument.Parse(RSSData);

                var a = this.rssFeedModelFactory
                    .Create(xml.Descendants(descendantElementName)).ToList();

                RSSFeedData.Add(a);
            }

            return RSSFeedData;
        }

        public IEnumerable<IRssFeed> GetSpecificFeed(string RSSURL, string descendantElementName)
        {
            var RSSData = this.webClient.DownloadString(RSSURL);

            var xml = this.xDocument.Parse(RSSData);

            var RSSFeedData = this.rssFeedModelFactory
                .Create(xml.Descendants(descendantElementName));

            return RSSFeedData;
        }
    }
}