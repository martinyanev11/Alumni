using Alumni.Data.Data;
using Alumni.Services.ServicesForCharityDonations;
using Alumni.Services.ServicesForCharityDonations.Models;
using Alumni.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Alumni.Web.Controllers
{
    // admin - add charity donation, edit charity donation, delete charity donation
    [Authorize(Roles = "Admin")]
    public class CharityDonationController : Controller
    {
        private readonly ICharityDonationServices _charityDonationService;

        public CharityDonationController(ICharityDonationServices charityDonationService)
        {
            _charityDonationService = charityDonationService;
        }

        [AllowAnonymous]
        public IActionResult All()
        {
            var charityDonations = _charityDonationService.GetAllCharityDonations();
            return View(charityDonations);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var viewModel = await _charityDonationService.GetDetailsAsync(id);

            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Donate(Guid id, decimal amount)
        {
            if (amount <= 0)
            {
                TempData["ErrorMessage"] = "Donation amount must be greater than 0.";
                return RedirectToAction("Details", new { id });
            }

            try
            {
                await _charityDonationService.DonateAsync(id, amount);
                TempData["SuccessMessage"] = $"Thank you for your donation of ${amount.ToString("N2")}!";
            }
            catch (InvalidOperationException)
            {
                TempData["ErrorMessage"] = "The donation campaign was not found.";
            }

            return RedirectToAction("Details", new { id });
        }

        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(CharityDonationFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _charityDonationService.AddCharityDonationAsync(model);
            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var model = await _charityDonationService.GetCharityDonationForEditAsync(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, CharityDonationFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _charityDonationService.EditCharityDonationAsync(id, model);
            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await _charityDonationService.DeleteCharityDonationAsync(id);
            return RedirectToAction(nameof(All));
        }
    }
}
