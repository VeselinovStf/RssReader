using RssReader.XDocumentWrapper.Abstract;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace RssReader.XDocumentWrapper
{
    public class RssReaderParseXDocument : IXDocumentParseWrapper
    {
        public XDocument Parse(string RSSData)
        {
            return XDocument.Parse(RSSData);
        }
    }
}