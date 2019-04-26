using Microsoft.Extensions.DependencyInjection;
using RssReader.Abstract;
using RssReader.Feed;
using RssReader.Model.Abstract;
using RssReader.ModelFactory.Abstract;
using RssReader.ModelFactory.Implementation.RssFeed;
using RssReader.Models.Implementations;
using RssReader.Repositories;
using RssReader.WebClientWrapper;
using RssReader.WebClientWrapper.Abstract;
using RssReader.XDocumentWrapper;
using RssReader.XDocumentWrapper.Abstract;
using System;
using System.Collections.Generic;
using System.Net;
using System.Xml.Linq;

namespace RssReader.Core.Container
{
    public class RssReaderNetCore2_2_Services
    {
        /// <summary>
        /// Register all RssReader futures and add list of url strings to display from
        ///     "RSS": [
        /// "",
        /// ""
        ///   ]
        /// Add Rss feeds to appsettings.json
        /// </summary>
        /// <param name="services">IServiceCollection</param>
        /// <param name="rssFeeds">Configuratio.GetSection("RSS").Get<IList<string>>());</param>
        public static void RegisterRssReaderServices(IServiceCollection services, IList<string> rssFeeds)
        {
            services.AddScoped<IWebClientWrapper, RssReaderWebClient>();
            services.AddScoped<WebClient, WebClient>();
            services.AddScoped<IXDocumentParseWrapper, RssReaderParseXDocument>();
            services.AddScoped<XDocument, XDocument>();
            services.AddScoped<IRssReaderModelFactory<BaseRssFeed>, RssFeedModeFactory>();
            services.AddScoped<IRssReaderRepository<IRssFeed>, RssFeedRepository>();
            services.AddScoped<IRssReaderFeed, RssReaderFeed>(r => new RssReaderFeed(rssFeeds));
        }
    }
}