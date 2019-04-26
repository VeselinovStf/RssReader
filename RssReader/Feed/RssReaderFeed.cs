using RssReader.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RssReader.Feed
{
    public class RssReaderFeed : IRssReaderFeed
    {
        public readonly IEnumerable<IFeedNode> FeedList;

        public RssReaderFeed(IEnumerable<string> feedList)
        {
            this.FeedList = feedList
                .Select(l => new FeedNode()
                {
                    URL = l
                });
        }

        public IEnumerable<IFeedNode> GetFeed()
        {
            return this.FeedList;
        }
    }
}