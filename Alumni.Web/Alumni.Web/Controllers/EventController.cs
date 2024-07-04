using Alumni.Data.Data;
using Alumni.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Alumni.Web.Controllers
{
    public class EventController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AlumniDbContext _context;
        public EventController(ILogger<HomeController> logger, AlumniDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Events()
        {
            List<EventViewModel> events;
            events = _context.Events.Select(e => new EventViewModel
            {
                Title = e.Title,
                Contents = e.Contents,
                CreatedOn = e.CreatedOn,
                LastEdited = e.LastEdited,
                ImageUrl = e.ImageUrl,
                EventId = e.EventId,
                StartDateTime = e.StartDateTime,
                EndDateTime = e.EndDateTime
            }).ToList();

            return View(events);
        }
    }
}
