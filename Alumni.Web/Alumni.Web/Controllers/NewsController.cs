using Alumni.Data.Data;
using Alumni.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Alumni.Web.Controllers
{

    public class NewsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AlumniDbContext _context;
        public NewsController(ILogger<HomeController> logger, AlumniDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult News()
        {
            List<NewsViewModel> news;
            news = _context.News.Select(e => new NewsViewModel
            {
                Title = e.Title,
                Contents = e.Contents,
                CreatedOn = e.CreatedOn,
                LastEdited = e.LastEdited,
                ImageUrl = e.ImageUrl,
                NewsId = e.NewsId
            }).ToList();
            return View(news);
        }
        public IActionResult NewsDetails(Guid newsId)
        {
            NewsViewModel details = _context.News.Where(x => x.NewsId == newsId).Select(d => new NewsViewModel
            {
                Title = d.Title,
                Contents = d.Contents,
                CreatedOn = d.CreatedOn,
                ImageUrl = d.ImageUrl,
                NewsId = d.NewsId,
                LastEdited = d.LastEdited,
            })
                 .FirstOrDefault();
            return View(details);
        }
    }
}