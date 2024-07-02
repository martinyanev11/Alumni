using Alumni.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Web.ViewModels
{
    public class AllContentViewModel
    {
        public List<Post> Posts { get; set; } = null!;
        public List<News> News { get; set; } = null!;
		public List<Event> Events { get; set; } = null!;
        public List<CharityDonation> CharityDonations { get; set; } = null!;
	}
}
