using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakewoodScoopScraper.Services
{
    public class NewsItem
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public DateTime Date { get; set; }
        public int Comments { get; set; }
        public string ImageUrl { get; set; }
    }
}
