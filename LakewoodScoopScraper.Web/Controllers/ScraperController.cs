using LakewoodScoopScraper.Services;
using Microsoft.AspNetCore.Mvc;

namespace LakewoodScoopScraper.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScraperController : ControllerBase
    {
        [HttpGet("getNewsItems")]
        public List<NewsItem> GetNewsItems() => Scraper.GetNewsItems();
    }
}
