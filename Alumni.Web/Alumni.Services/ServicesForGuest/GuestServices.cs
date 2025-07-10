using Alumni.Data.Data;
using Alumni.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Services.ServicesForGuest
{
    public class GuestServices : IGuestServices
    {
        private readonly AlumniDbContext _context;

        public GuestServices(AlumniDbContext context)
        {
            _context = context;
        }

        public IEnumerable<HelpRequest> GetAllRequests()
        {
            return _context.HelpRequests
                .OrderByDescending(r => r.CreatedOn)
                .ToList();
        }

        public HelpRequest GetRequestById(int id)
        {
            return _context.HelpRequests
                .Where(r => r.Id == id)
                .Select(r => new HelpRequest
                {
                    Id = r.Id,
                    Title = r.Title,
                    Description = r.Description,
                    CreatedOn = r.CreatedOn,
                    Responses = r.Responses.OrderByDescending(res => res.CreatedOn).ToList()
                })
                .FirstOrDefault();
        }

        public void CreateRequest(HelpRequest request)
        {
            request.CreatedOn = DateTime.Now;
            _context.HelpRequests.Add(request);
            _context.SaveChanges();
        }

        public void AddResponse(int requestId, string content, string responderName)
        {
            var response = new HelpResponse
            {
                HelpRequestId = requestId,
                Content = content,
                ResponderName = responderName,
                CreatedOn = DateTime.Now
            };

            _context.HelpResponses.Add(response);
            _context.SaveChanges();
        }
    }
}
