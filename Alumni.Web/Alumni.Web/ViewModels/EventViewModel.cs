using System.ComponentModel.DataAnnotations;

namespace Alumni.Web.ViewModels
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
	}
}
