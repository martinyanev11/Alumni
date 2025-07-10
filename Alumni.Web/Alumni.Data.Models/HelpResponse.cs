﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Data.Models
{
    public class HelpResponse
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string ResponderName { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public int HelpRequestId { get; set; }
        public HelpRequest HelpRequest { get; set; }
    }


}
