using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Services.ServicesForEvents.Models
{
	public class EventViewModel
	{
		public DateTime CreatedOn { get; set; }
		public DateTime LastEdited { get; set; }
		public Guid EventId { get; set; }
		public string Title { get; set; }
		public string Contents { get; set; }
		public DateTime StartDateTime { get; set; }
		public DateTime EndDateTime { get; set; }
		public string ImageUrl { get; set; }
	}
}
