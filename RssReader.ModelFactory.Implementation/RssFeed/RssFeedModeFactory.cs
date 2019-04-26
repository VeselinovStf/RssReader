using RssReader.Model.Abstract;
using RssReader.ModelFactory.Abstract;
using RssReader.Models.Implementations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Linq;

namespace RssReader.ModelFactory.Implementation.RssFeed
{
    public class RssFeedModeFactory : IRssReaderModelFactory<BaseRssFeed>
    {
        public IEnumerable<BaseRssFeed> Create(IEnumerable<XElement> elements)
        {
            var RSSFeedData = (from x in elements
                               select new BaseRssFeed
                               {
                                   Title = ((string)x.Element("title")),
                                   Link = ((string)x.Element("link")),
                                   Description = ((string)x.Element("description")),
                                   PubDate = ((string)x.Element("pubDate"))
                               });

            return RSSFeedData;
        }
    }
}