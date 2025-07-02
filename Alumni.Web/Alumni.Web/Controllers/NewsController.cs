using Alumni.Data.Data;
using Alumni.Services.ServicesForNews;
using Alumni.Services.ServicesForNews.Models;
using Alumni.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Alumni.Web.Controllers
{
	 //admin - add news, edit news, delete news


	public class NewsController : Controller
	{
		private readonly INewsService _newsService;

		public NewsController(INewsService newsService)
		{
			_newsService = newsService;
		}

		// Show all news to all users (public)
		[AllowAnonymous]
		public async Task<IActionResult> All()
		{
			var news = await _newsService.GetAllNewsAsync();
			return View(news);
		}

		// News details (public)
		[AllowAnonymous]
		public async Task<IActionResult> Details(string id)
		{
			var news = await _newsService.GetNewsByIdAsync(id);
			if (news == null) return NotFound();
			return View(news);
		}

		// Admin-only: Create news
		[Authorize(Roles = "Admin")]
		[HttpGet]
		public IActionResult Create() => View();

		[Authorize(Roles = "Admin")]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(NewsModel model)
		{
			if (!ModelState.IsValid)
				return View(model);

			await _newsService.CreateNewsAsync(model);
			return RedirectToAction(nameof(All));
		}

		// Admin-only: Edit news
		[Authorize(Roles = "Admin")]
		[HttpGet]
		public async Task<IActionResult> Edit(string id)
		{
			var news = await _newsService.GetNewsByIdAsync(id);
			if (news == null) return NotFound();
			return View(news);
		}

		[Authorize(Roles = "Admin")]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(NewsModel model)
		{
			if (!ModelState.IsValid)
				return View(model);

			await _newsService.UpdateNewsAsync(model);
			return RedirectToAction(nameof(Details), new { id = model.NewsId });
		}

		// Admin-only: Delete news
		[Authorize(Roles = "Admin")]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Delete(string id)
		{
			await _newsService.DeleteNewsAsync(id);
			return RedirectToAction(nameof(All));
		}
	}
}