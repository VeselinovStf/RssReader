# RSS Reader

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

![](https://github.com/VeselinovStf/RssReader/blob/master/repoImg/demo.jpeg)

Read RSS feed using ASP .NET CORE

# Features

  - Reads Rss feads
  - Optional input of feed
  - Optional display

You can also:
  - Extend existing futures

### Tech

Used technologies

* .NET Core 2.2
* ASP.NET CORE MVC ( for Demo project )

### Installation

RssReader requires [.NET CORE 2.2] to run.

Clone or Download project.

Use:
```sh
RssReader.Core
RssReader.Models
RssReader.Wrappers

```

### Setting Up

Create rss feed model class

```sh
    public class RssFeedViewModel
    {
        public IEnumerable<IEnumerable<IRssFeed>> RssList { get; set; }

        public IEnumerable<IRssFeed> RssFeed { get; set; }

        public string URL { get; set; }
    }
```


### Register Functions

```sh
RssReaderNetCore2_2_Services.RegisterRssReaderServices(
                services, Configuration
                    .GetSection("RSS")
                    .Get<IList<string>>());
```
### Add build in RSS feeds

Add to appsettings.json

```sh
 "RSS": [
    "http://www.vesti.bg/rss.php",
    "https://www.24chasa.bg/Rss"
  ]
```

### Example

RssReader.Web - HomeController

### Current Build Functions

- Execute ( Core function  )
```sh
- IRssReaderRepository<IRssFeed>
```

### Todos

- Update formating of output - some times its spits html tags

License
----

MIT