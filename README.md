# RssReader
ASP .NET CORE 2.2 RSS Reader
-----------------------
Read RSS feed using ASP .NET CORE
----------------------

USAGE
-----------------------
1. Clone or download project zip - https://github.com/VeselinovStf/RssReader.git
2. Add RssReader Core, Models, Wrappers to project
3. Add to Startup.cs Config -  RssReaderNetCore2_2_Services.RegisterRssReaderServices(services, Configuratio.GetSection("RSS").Get<IList<string>>());
4. Add Rss Feed in appsettings,json
5. Use in controller - var RSSFeedData = this.rssFeedRepository.GetListedFeed("item"); or var RSSFeedData = this.rssFeedRepository.GetSpecificFeed(model.URL, "item");