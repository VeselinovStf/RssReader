using RssReader.Model.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;

namespace RssReader.Abstract
{
    public interface IRssReaderRepository<IRssFeed>
    {
        IEnumerable<IEnumerable<IRssFeed>> GetListedFeed(string descendantElementName);

        IEnumerable<IRssFeed> GetSpecificFeed(string RSSURL, string descendantElementName);
    }
}