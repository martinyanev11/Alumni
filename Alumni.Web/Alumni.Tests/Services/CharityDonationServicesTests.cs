﻿using Alumni.Data.Data;
using Alumni.Data.Models;
using Alumni.Services.ServicesForCharityDonations;
using Alumni.Services.ServicesForCharityDonations.Models;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Alumni.Tests
{
    public class CharityDonationServicesTests
    {
        private CharityDonationServices GetServiceWithInMemoryDb()
        {
            var options = new DbContextOptionsBuilder<AlumniDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()) // unique DB for each test
                .Options;

            var context = new AlumniDbContext(options);

            return new CharityDonationServices(context);
        }

        [Fact]
        public void GetAllCharityDonations_ReturnsAllDonations()
        {
            // Arrange
            var service = GetServiceWithInMemoryDb();
            var context = service.GetType().GetField("_context", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(service) as AlumniDbContext;

            var donation1 = new CharityDonation
            {
                CharityDonationId = Guid.NewGuid(),
                Title = "Test Donation 1",
                Content = "Content 1",
                ImageUrl = "image1.jpg",
                DonationGoal = 500,
                CurrentlyRaisedDonations = 150,
                CreatedOn = DateTime.UtcNow
            };

            var donation2 = new CharityDonation
            {
                CharityDonationId = Guid.NewGuid(),
                Title = "Test Donation 2",
                Content = "Content 2",
                ImageUrl = "image2.jpg",
                DonationGoal = 1000,
                CurrentlyRaisedDonations = 300,
                CreatedOn = DateTime.UtcNow
            };

            context.CharityDonations.AddRange(donation1, donation2);
            context.SaveChanges();

            // Act
            var result = service.GetAllCharityDonations();

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Contains(result, d => d.Title == "Test Donation 1");
            Assert.Contains(result, d => d.Title == "Test Donation 2");
        }

        [Fact]
        public void GetAllCharityDonations_ReturnsEmpty_WhenNoDonationsExist()
        {
            // Arrange
            var service = GetServiceWithInMemoryDb();

            // Act
            var result = service.GetAllCharityDonations();

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public async Task AddCharityDonationAsync_AddsDonationCorrectly()
        {
            // Arrange
            var service = GetServiceWithInMemoryDb();
            var context = service.GetType().GetField("_context", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(service) as AlumniDbContext;

            var formModel = new CharityDonationFormModel
            {
                Title = "New Donation",
                Content = "Help us",
                ImageUrl = "donate.jpg",
                DonationGoal = 1000
            };

            // Act
            await service.AddCharityDonationAsync(formModel);

            // Assert
            var donation = context.CharityDonations.FirstOrDefault();
            Assert.NotNull(donation);
            Assert.Equal("New Donation", donation.Title);
            Assert.Equal("Help us", donation.Content);
            Assert.Equal(1000, donation.DonationGoal);
            Assert.Equal(0, donation.CurrentlyRaisedDonations);
            Assert.Equal("donate.jpg", donation.ImageUrl);
        }

        [Fact]
        public async Task DonateAsync_IncreasesRaisedAmount()
        {
            var options = new DbContextOptionsBuilder<AlumniDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()) // ensures unique, isolated DB
            .Options;

            using var context = new AlumniDbContext(options);
            var service = new CharityDonationServices(context);

            var donationId = Guid.NewGuid();
            var donation = new CharityDonation
            {
                CharityDonationId = donationId,
                Title = "Donation Test",
                Content = "Content",
                DonationGoal = 1000m,
                CurrentlyRaisedDonations = 200m,
                CreatedOn = DateTime.UtcNow,
                ImageUrl = "test.jpg"
            };

            context.CharityDonations.Add(donation);
            await context.SaveChangesAsync();

            // Act
            await service.DonateAsync(donationId, 50m);

            // Assert
            var updated = await context.CharityDonations.FindAsync(donationId);
            Assert.Equal(250m, updated.CurrentlyRaisedDonations);
        }

        [Fact]
        public async Task DonateAsync_Throws_WhenDonationDoesNotExist()
        {
            // Arrange
            var service = GetServiceWithInMemoryDb();
            var nonExistentId = Guid.NewGuid();

            // Act & Assert
            await Assert.ThrowsAsync<InvalidOperationException>(async () =>
            {
                await service.DonateAsync(nonExistentId, 100m);
            });
        }

        [Fact]
        public async Task DonateAsync_Throws_WhenAmountIsNegative()
        {
            // Arrange
            var service = GetServiceWithInMemoryDb();
            var context = service.GetType().GetField("_context", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(service) as AlumniDbContext;
            var donation = new CharityDonation
            {
                CharityDonationId = Guid.NewGuid(),
                Title = "Donation",
                Content = "Content",
                DonationGoal = 1000m,
                CurrentlyRaisedDonations = 0m,
                CreatedOn = DateTime.UtcNow,
                ImageUrl = "img.jpg"
            };
            context!.CharityDonations.Add(donation);
            context.SaveChanges();
            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                await service.DonateAsync(donation.CharityDonationId, -50m);
            });
        }

        [Fact]
        public async Task DonateAsync_CapsAtDonationGoal()
        {
            // Arrange
            var service = GetServiceWithInMemoryDb();
            var context = service.GetType().GetField("_context", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(service) as AlumniDbContext;
            var donation = new CharityDonation
            {
                CharityDonationId = Guid.NewGuid(),
                Title = "Donation",
                Content = "Content",
                DonationGoal = 100m,
                CurrentlyRaisedDonations = 90m,
                CreatedOn = DateTime.UtcNow,
                ImageUrl = "img.jpg"
            };
            context!.CharityDonations.Add(donation);
            context.SaveChanges();
            // Act
            await service.DonateAsync(donation.CharityDonationId, 20m); // Should cap at 100
            // Assert
            var updated = context.CharityDonations.Find(donation.CharityDonationId);
            Assert.NotNull(updated);
            Assert.Equal(100m, updated.CurrentlyRaisedDonations);
        }

        [Fact]
        public async Task AddCharityDonationAsync_SetsDefaultValues()
        {
            // Arrange
            var service = GetServiceWithInMemoryDb();
            var context = service.GetType().GetField("_context", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(service) as AlumniDbContext;
            var formModel = new CharityDonationFormModel
            {
                Title = "Default Test",
                Content = "Content",
                ImageUrl = "img.jpg",
                DonationGoal = 100
            };
            // Act
            await service.AddCharityDonationAsync(formModel);
            // Assert
            var donation = context!.CharityDonations.FirstOrDefault(d => d.Title == "Default Test");
            Assert.NotNull(donation);
            Assert.Equal(0, donation.CurrentlyRaisedDonations);
            Assert.True(donation.CreatedOn <= DateTime.UtcNow);
        }

        [Fact]
        public async Task AddCharityDonationAsync_Throws_WhenDonationGoalIsZeroOrNegative()
        {
            // Arrange
            var service = GetServiceWithInMemoryDb();
            var context = service.GetType().GetField("_context", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(service) as AlumniDbContext;
            var formModel = new CharityDonationFormModel
            {
                Title = "Invalid Goal",
                Content = "Content",
                ImageUrl = "img.jpg",
                DonationGoal = 0
            };
            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                await service.AddCharityDonationAsync(formModel);
            });
        }
    }
}
