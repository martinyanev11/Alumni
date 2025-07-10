using Alumni.Data.Data;
using Alumni.Data.Models;
using Alumni.Services.ServicesForCharityDonations.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Services.ServicesForCharityDonations
{
	public class CharityDonationServices : ICharityDonationServices
	{
        private readonly AlumniDbContext _context;

        public CharityDonationServices(AlumniDbContext context)
        {
            _context = context;
        }

        public List<CharityDonationViewModelForServiec> GetAllCharityDonations()
        {
            return _context.CharityDonations
                .Select(ch => new CharityDonationViewModelForServiec
                {
                    CharityDonationId = ch.CharityDonationId,
                    DonationGoal = ch.DonationGoal,
                    CurrentlyRaisedDonations = ch.CurrentlyRaisedDonations,
                    Donators = ch.Donators.Select(d => d.User).ToList(),
                    ImageUrl = ch.ImageUrl,
                    CreatedOn = ch.CreatedOn,
                    Title = ch.Title,
                    Content = ch.Content,
                })
                .ToList();
        }

        public async Task<CharityDonationViewModelForServiec> GetDetailsAsync(Guid id)
        {
            var donation = await _context.CharityDonations
                .Include(cd => cd.Donators)
                .FirstOrDefaultAsync(cd => cd.CharityDonationId == id);

            if (donation == null)
            {
                return null;
            }

            return new CharityDonationViewModelForServiec
            {
                CharityDonationId = donation.CharityDonationId,
                Title = donation.Title,
                Content = donation.Content,
                ImageUrl = donation.ImageUrl,
                DonationGoal = donation.DonationGoal,
                CurrentlyRaisedDonations = donation.CurrentlyRaisedDonations,
                CreatedOn = donation.CreatedOn
            };
        }

        public async Task DonateAsync(Guid id, decimal amount)
        {
            var donation = await _context.CharityDonations
                .Include(cd => cd.Donators)
                .FirstOrDefaultAsync(cd => cd.CharityDonationId == id);

            if (donation == null)
            {
                throw new InvalidOperationException("Donation campaign not found.");
            }

            // Update raised amount
            donation.CurrentlyRaisedDonations += amount;

            await _context.SaveChangesAsync();
        }

        public async Task AddCharityDonationAsync(CharityDonationFormModel model)
        {
            var donation = new CharityDonation
            {
                Title = model.Title,
                Content = model.Content,
                ImageUrl = model.ImageUrl,
                DonationGoal = model.DonationGoal,
                CurrentlyRaisedDonations = 0,
                CreatedOn = DateTime.UtcNow,
            };

            await _context.CharityDonations.AddAsync(donation);
            await _context.SaveChangesAsync();
        }

        public async Task EditCharityDonationAsync(Guid id, CharityDonationFormModel model)
        {
            var donation = await _context.CharityDonations.FindAsync(id);
            if (donation != null)
            {
                donation.Title = model.Title;
                donation.Content = model.Content;
                donation.ImageUrl = model.ImageUrl;
                donation.DonationGoal = model.DonationGoal;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteCharityDonationAsync(Guid id)
        {
            var donation = await _context.CharityDonations.FindAsync(id);
            if (donation != null)
            {
                _context.CharityDonations.Remove(donation);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<CharityDonationFormModel?> GetCharityDonationForEditAsync(Guid id)
        {
            return await _context.CharityDonations
                .Where(ch => ch.CharityDonationId == id)
                .Select(ch => new CharityDonationFormModel
                {
                    Title = ch.Title,
                    Content = ch.Content,
                    ImageUrl = ch.ImageUrl,
                    DonationGoal = ch.DonationGoal,
                })
                .FirstOrDefaultAsync();
        }
    }
}
