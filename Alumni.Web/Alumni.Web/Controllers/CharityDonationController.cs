using Alumni.Data.Data;
using Alumni.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Alumni.Web.Controllers
{
	// admin - add charity donation, edit charity donation, delete charity donation
	public class CharityDonationController : Controller
    {
		private readonly AlumniDbContext _context;
		public CharityDonationController(AlumniDbContext context)
		{
			_context = context;
		}
		public IActionResult All()
		{
			List<CharityDonationViewModel> charityDonations = _context.CharityDonations.Select(ch => new CharityDonationViewModel
			{
				DonationGoal = ch.DonationGoal,
				CurrentlyRaisedDonations = ch.CurrentlyRaisedDonations,
				Donators = ch.Donators.Select(ch => ch.User).ToList(),
				ImageUrl = ch.ImageUrl,
				CreatedOn = ch.CreatedOn,
				Title = ch.Title,
				Content = ch.Content,
			})
				.ToList();

			return View(charityDonations);
		}

	}
}
