using System.ComponentModel.DataAnnotations;

namespace Alumni.Web.ViewModels
{
	public class NewsViewModel
	{
		public DateTime CreatedOn { get; set; }
		public Guid NewsId { get; set; }
		public DateTime LastEdited { get; set; }
		public string Title { get; set; }
		public string Contents { get; set; }
        public string ImageUrl { get; set; }

    }
}
