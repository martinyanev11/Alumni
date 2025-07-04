using Alumni.Data.Data;
using Alumni.Services.ServicesForEvents.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Services.ServicesForEvents
{
	public class EventServices : IEventServices
	{
		private readonly AlumniDbContext _context;

		public EventServices(AlumniDbContext context)
		{
			_context = context;
		}

		public async Task<List<EventViewModelForService>> GetAllEventsAsync()
		{
			return await _context.Events
				.Select(e => new EventViewModelForService
				{
					EventId = e.EventId,
					Title = e.Title,
					Contents = e.Contents,
					CreatedOn = e.CreatedOn,
					LastEdited = e.LastEdited,
					ImageUrl = e.ImageUrl,
					StartDateTime = e.StartDateTime,
					EndDateTime = e.EndDateTime
				}).ToListAsync();
		}

		public async Task<EventViewModelForService> GetEventByIdAsync(Guid eventId)
		{
			var e = await _context.Events.FindAsync(eventId);
			if (e == null) return null;

			return new EventViewModelForService
			{
				EventId = e.EventId,
				Title = e.Title,
				Contents = e.Contents,
				CreatedOn = e.CreatedOn,
				LastEdited = e.LastEdited,
				ImageUrl = e.ImageUrl,
				StartDateTime = e.StartDateTime,
				EndDateTime = e.EndDateTime
			};
		}

		public async Task AddEventAsync(EventViewModelForService model)
		{
			var newEvent = new Data.Models.Event
			{
				Title = model.Title,
				Contents = model.Contents,
				CreatedOn = model.CreatedOn,
				LastEdited = model.LastEdited,
				ImageUrl = model.ImageUrl,
				StartDateTime = model.StartDateTime,
				EndDateTime = model.EndDateTime
			};

			await _context.Events.AddAsync(newEvent);
			await _context.SaveChangesAsync();
		}

		public async Task EditEventAsync(EventViewModelForService model)
		{
			var existingEvent = await _context.Events.FindAsync(model.EventId);
			if (existingEvent == null) return;

			existingEvent.Title = model.Title;
			existingEvent.Contents = model.Contents;
			existingEvent.LastEdited = model.LastEdited;
			existingEvent.ImageUrl = model.ImageUrl;
			existingEvent.StartDateTime = model.StartDateTime;
			existingEvent.EndDateTime = model.EndDateTime;

			_context.Events.Update(existingEvent);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteEventAsync(Guid eventId)
		{
			var existingEvent = await _context.Events.FindAsync(eventId);
			if (existingEvent == null) return;

			_context.Events.Remove(existingEvent);
			await _context.SaveChangesAsync();
		}
	}
}
