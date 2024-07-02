using Alumni.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.Data;
namespace Alumni.Web.ViewModels
{
	public class PostViewModel
	{
		public Guid PostId { get; set; }

		public string Title { get; set; } = null!;

		public string Contents { get; set; } = null!;

		public DateTime CreatedOn { get; set; }

		public DateTime LastEdited { get; set; }
	}
}
