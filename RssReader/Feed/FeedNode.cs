using RssReader.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RssReader.Feed
{
    public class FeedNode : IFeedNode
    {
        public string URL { get; set; }
    }
}