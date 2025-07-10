using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Alumni.Services.Email
{
    public class DummyEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Logs to Debug output for visibility during development
            Debug.WriteLine($"Sending Email to: {email}");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine($"Message: {htmlMessage}");

            // No actual email sending in development
            return Task.CompletedTask;
        }
    }
}
