using Alumni.Services.ServicesForEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Services.ServicesForEvents
{
	public interface IEventServices
	{
		Task<List<EventViewModelForService>> GetAllEventsAsync();
		Task<EventViewModelForService> GetEventByIdAsync(Guid eventId);
		Task AddEventAsync(EventViewModelForService model);
		Task EditEventAsync(EventViewModelForService model);
		Task DeleteEventAsync(Guid eventId);
	}
}
