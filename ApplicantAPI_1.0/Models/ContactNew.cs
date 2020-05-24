using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class ContactNew
    {
        public int ContactId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Ddi { get; set; }
        public string Mobile { get; set; }
        public string Firm { get; set; }
        public int? Position { get; set; }
        public int? PositionType { get; set; }
        public int? Source { get; set; }
        public string Note { get; set; }
        public int? Account { get; set; }
        public int? Display { get; set; }
    }
}
