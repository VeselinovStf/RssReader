using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RssReader.Abstract;
using RssReader.Model.Abstract;
using RssReader.Web.Models;

namespace RssReader.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRssReaderRepository<IRssFeed> rssFeedRepository;

        public HomeController(IRssReaderRepository<IRssFeed> rssFeedRepository)
        {
            this.rssFeedRepository = rssFeedRepository;
        }

        public IActionResult Index()
        {
            var RSSFeedData = this.rssFeedRepository.GetListedFeed("item");

            var model = new RssFeedViewModel()
            {
                RssList = RSSFeedData,
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(RssFeedViewModel model)
        {
            if (model.URL == null)
            {
                throw new ArgumentException("Model state was invalid");
            }

            var RSSFeedData = this.rssFeedRepository.GetSpecificFeed(model.URL, "item");

            var viewModel = new RssFeedViewModel()
            {
                RssFeed = RSSFeedData,
                URL = model.URL
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}