using Alumni.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Alumni.Web.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Guest()
        {
            var news = new List<NewsViewModel>
            {
                new NewsViewModel { Title = "News 1", Contents = "Content of news 1", ImageUrl = "/images/event3.jpg" },
                new NewsViewModel { Title = "News 2", Contents = "Content of news 2", ImageUrl = "/images/event3.jpg" },
                new NewsViewModel { Title = "News 3", Contents = "Content of news 3", ImageUrl = "/images/event3.jpg" }
            };

            var events = new List<EventViewModel>
            {
                new EventViewModel { Title = "Event 1", Contents = "Content of event 1", ImageUrl = "/images/event3.jpg" },
                new EventViewModel { Title = "Event 2", Contents = "Content of event 2", ImageUrl = "/images/event3.jpg" },
                new EventViewModel { Title = "Event 3", Contents = "Content of event 3", ImageUrl = "/images/event3.jpg" }
            };

            var viewModel = new GuestViewModel
            {
                News = news,
                Events = events
            };

            return View(viewModel);
        }
    }
}
