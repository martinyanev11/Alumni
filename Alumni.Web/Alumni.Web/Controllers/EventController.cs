using Alumni.Services.ServicesForEvents;
using Alumni.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ServiceEventVM = Alumni.Services.ServicesForEvents.Models.EventViewModelForService; 

namespace Alumni.Web.Controllers
{
	[Authorize]
	public class EventController : Controller
	{
		private readonly IEventServices _eventService;

		public EventController(IEventServices eventService)
		{
			_eventService = eventService;
		}

		[AllowAnonymous]
		public async Task<IActionResult> Events()
		{
			var serviceEvents = await _eventService.GetAllEventsAsync();

			var webEvents = serviceEvents.ConvertAll(e => new EventViewModel
			{
				EventId = e.EventId,
				Title = e.Title,
				Contents = e.Contents,
				CreatedOn = e.CreatedOn,
				LastEdited = e.LastEdited,
				ImageUrl = e.ImageUrl,
				StartDateTime = e.StartDateTime,
				EndDateTime = e.EndDateTime
			});

			return View(webEvents);
		}

		[HttpGet]
		public IActionResult Add() => View();

		[HttpPost]
		public async Task<IActionResult> Add(EventViewModel model)
		{
			if (!ModelState.IsValid) return View(model);

			model.CreatedOn = System.DateTime.UtcNow;
			model.LastEdited = System.DateTime.UtcNow;

			var serviceModel = new ServiceEventVM
			{
				EventId = model.EventId,
				Title = model.Title,
				Contents = model.Contents,
				CreatedOn = model.CreatedOn,
				LastEdited = model.LastEdited,
				ImageUrl = model.ImageUrl,
				StartDateTime = model.StartDateTime,
				EndDateTime = model.EndDateTime
			};

			await _eventService.AddEventAsync(serviceModel);

			return RedirectToAction(nameof(Events));
		}

		[HttpGet]
		public async Task<IActionResult> Edit(Guid id)
		{
			var serviceModel = await _eventService.GetEventByIdAsync(id);
			if (serviceModel == null) return NotFound();

			var webModel = new EventViewModel
			{
				EventId = serviceModel.EventId,
				Title = serviceModel.Title,
				Contents = serviceModel.Contents,
				CreatedOn = serviceModel.CreatedOn,
				LastEdited = serviceModel.LastEdited,
				ImageUrl = serviceModel.ImageUrl,
				StartDateTime = serviceModel.StartDateTime,
				EndDateTime = serviceModel.EndDateTime
			};

			return View(webModel);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(EventViewModel model)
		{
			if (!ModelState.IsValid) return View(model);

			model.LastEdited = System.DateTime.UtcNow;

			var serviceModel = new ServiceEventVM
			{
				EventId = model.EventId,
				Title = model.Title,
				Contents = model.Contents,
				CreatedOn = model.CreatedOn,
				LastEdited = model.LastEdited,
				ImageUrl = model.ImageUrl,
				StartDateTime = model.StartDateTime,
				EndDateTime = model.EndDateTime
			};

			await _eventService.EditEventAsync(serviceModel);

			return RedirectToAction(nameof(Events));
		}

		[HttpPost]
		public async Task<IActionResult> Delete(Guid id)
		{
			await _eventService.DeleteEventAsync(id);
			return RedirectToAction(nameof(Events));
		}
	}
}
