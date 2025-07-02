using Alumni.Data.Data;
using Alumni.Data.Models;
using Alumni.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace Alumni.Web.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AlumniDbContext _context;
        private readonly UserManager<User> _userManager;
		public HomeController(ILogger<HomeController> logger, AlumniDbContext context, UserManager<User> userManager)
		{
			_logger = logger;
			_context = context;
			_userManager = userManager;
		}

		public IActionResult Index()
        {

			var models = new AllContentViewModel();

			models.Posts = _context.Posts.OrderByDescending(x => x.CreatedOn).Take(3).ToList();
			models.News = _context.News.OrderByDescending(x => x.CreatedOn).Take(3).ToList();
			models.Events = _context.Events.OrderByDescending(x => x.CreatedOn).Take(3).ToList();
            models.CharityDonations = _context.CharityDonations.OrderByDescending(x => x.CreatedOn).Take(3).ToList(); 

            return View(models);
		}

        public IActionResult Privacy()
        {
            return View();
        }

		public async Task<IActionResult> IsUserInRole(string roleName)
		{
			if (User.Identity.IsAuthenticated)
			{
				var user = await _userManager.GetUserAsync(User);
				if (user != null)
				{
					bool isInRole = await _userManager.IsInRoleAsync(user, roleName);
					return Json(isInRole); // Returns true or false as JSON
				}
			}
			return Json(false); // Not authenticated or user not found
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            switch (statusCode) 
            {
                case 400:
                case 401:
                case 403:
                case 404:
                case 500:
                return View($"Error{statusCode}");
                    
            }

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
