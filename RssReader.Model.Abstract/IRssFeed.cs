﻿using System;

namespace RssReader.Model.Abstract
{
    public interface IRssFeed
    {
         string Title { get; set; }

         string Description { get; set; }

         string Link { get; set; }

        string PubDate { get; set; }
    }
}
