using Alumni.Data.Models;
using Alumni.Services.ServicesForGuest;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Alumni.Web.Controllers
{
    [Authorize] // Optional: ensures only logged-in users can respond
    public class GuestController : Controller
    {
        private readonly IGuestServices _guestService;

        public GuestController(IGuestServices guestService)
        {
            _guestService = guestService;
        }

        public IActionResult Guest()
        {
            var requests = _guestService.GetAllRequests();
            return View(requests); // Views/Guest/Guest.cshtml
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HelpRequest model)
        {
            if (ModelState.IsValid)
            {
                _guestService.CreateRequest(model);
                return RedirectToAction("Guest");
            }
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var request = _guestService.GetRequestById(id);
            if (request == null)
                return NotFound();

            return View(request); // Views/Guest/Details.cshtml
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddResponse(int id, string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                ModelState.AddModelError("Content", "Response content cannot be empty.");
                return RedirectToAction("Details", new { id });
            }

            string responderEmail = User.Identity?.Name ?? "Anonymous";
            _guestService.AddResponse(id, content, responderEmail);

            return RedirectToAction("Details", new { id });
        }
    }
}