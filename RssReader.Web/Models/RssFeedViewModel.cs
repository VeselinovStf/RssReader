using RssReader.Model.Abstract;
using RssReader.Models.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RssReader.Web.Models
{
    public class RssFeedViewModel
    {
        public IEnumerable<IEnumerable<IRssFeed>> RssList { get; set; }

        public IEnumerable<IRssFeed> RssFeed { get; set; }

        public string URL { get; set; }
    }
}