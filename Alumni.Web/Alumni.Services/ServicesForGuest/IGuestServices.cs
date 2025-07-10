using Alumni.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Services.ServicesForGuest
{
    public interface IGuestServices
    {
        IEnumerable<HelpRequest> GetAllRequests();
        HelpRequest GetRequestById(int id);
        void CreateRequest(HelpRequest request);
        void AddResponse(int requestId, string content, string responderName);

    }
}
