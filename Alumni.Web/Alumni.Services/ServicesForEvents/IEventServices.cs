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
		Task<List<EventViewModel>> GetAllEventsAsync();
		Task<EventViewModel> GetEventByIdAsync(int eventId);
		Task AddEventAsync(EventViewModel model);
		Task EditEventAsync(EventViewModel model);
		Task DeleteEventAsync(int eventId);
	}
}
