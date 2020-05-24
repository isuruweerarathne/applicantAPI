using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class ContactRequest
    {
        public int ContactInd { get; set; }
        public string Name { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime? DateTim { get; set; }
        public int? Suggrespons { get; set; }
        public string EmailAddress { get; set; }
        public string TelNo { get; set; }
        public string Message { get; set; }
        public byte? DealtWith { get; set; }
    }
}
