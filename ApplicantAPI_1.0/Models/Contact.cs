using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime? DteTime { get; set; }
        public string Ipaddr { get; set; }
    }
}
