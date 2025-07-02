using Alumni.Data.Models;

namespace Alumni.Web.ViewModels
{
	public class HomePageViewModel
	{
		public List<Post> Posts { get; set; } = null!;
		public List<News> News { get; set; } = null!;
		public List<Event> Events { get; set; } = null!;
		public List<CharityDonation> CharityDonations { get; set; } = null!;

	}
}
