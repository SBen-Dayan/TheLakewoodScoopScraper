using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakewoodScoopScraper.Services
{
    public static class Scraper
    {
        public static List<NewsItem> GetNewsItems()
        {
            var document = GetDocument();
            var newsItems = document.QuerySelectorAll("div.td-category-pos-image");
            return newsItems.Select(ParseNewsItem).ToList();
        }

        private static IHtmlDocument GetDocument()
        {
            var html = new HttpClient().GetStringAsync("https://thelakewoodscoop.com/").Result;
            return new HtmlParser().ParseDocument(html);
        }

        private static NewsItem ParseNewsItem(IElement newsItem)
        {
            var titleUrl = newsItem.QuerySelector("h3.entry-title").QuerySelector("a");
            return new NewsItem
            {
                Title = titleUrl.TextContent,
                Url = titleUrl.Attributes["href"].Value,
                ImageUrl = newsItem.QuerySelector("span.entry-thumb").Attributes["data-img-url"].Value,
                Date = DateTime.Parse(newsItem.QuerySelector("time.entry-date").Attributes["datetime"].Value),
                Comments = int.Parse(newsItem.QuerySelector("span.td-module-comments").QuerySelector("a").TextContent),
                Excerpt = newsItem.QuerySelector("div.td-excerpt").TextContent
            };
        }
    }
}
