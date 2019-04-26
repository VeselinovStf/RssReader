using System;
using System.Collections.Generic;
using System.Text;

namespace RssReader.Abstract
{
    public interface IRssReaderFeed
    {
        IEnumerable<IFeedNode> GetFeed();
    }
}