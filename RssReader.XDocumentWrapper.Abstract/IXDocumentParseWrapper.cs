using System;
using System.Xml.Linq;

namespace RssReader.XDocumentWrapper.Abstract
{
    public interface IXDocumentParseWrapper
    {
        XDocument Parse(string RSSData);
    }
}