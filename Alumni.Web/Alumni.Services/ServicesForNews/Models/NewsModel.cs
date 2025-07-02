using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Services.ServicesForNews.Models
{
	public class NewsModel
	{
		public DateTime CreatedOn { get; set; }
		public Guid NewsId { get; set; }
		public DateTime LastEdited { get; set; }
		public string Title { get; set; }
		public string Contents { get; set; }
		public string ImageUrl { get; set; }
	}
}
