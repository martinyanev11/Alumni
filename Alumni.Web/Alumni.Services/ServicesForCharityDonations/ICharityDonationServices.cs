using Alumni.Services.ServicesForCharityDonations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Services.ServicesForCharityDonations
{
	public interface ICharityDonationServices
	{
        List<CharityDonationViewModelForServiec> GetAllCharityDonations();
        Task AddCharityDonationAsync(CharityDonationFormModel model);
        Task EditCharityDonationAsync(Guid id, CharityDonationFormModel model);
        Task DeleteCharityDonationAsync(Guid id);
        Task<CharityDonationViewModelForServiec> GetDetailsAsync(Guid id);
        Task DonateAsync(Guid id, decimal amount);
        Task<CharityDonationFormModel?> GetCharityDonationForEditAsync(Guid id);
    }
}
