using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class UserValidation
    {
        public int UserIndex { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public byte? UserType { get; set; }
        public byte? SecurityLevel { get; set; }
        public string ContactNo { get; set; }
        public int? AffiliateNo { get; set; }
        public byte? Department1 { get; set; }
        public byte? Department2 { get; set; }
        public byte? Department3 { get; set; }
        public byte? Department4 { get; set; }
        public byte? Department5 { get; set; }
        public byte? Department6 { get; set; }
        public byte? Department7 { get; set; }
        public byte? Department8 { get; set; }
        public byte? Department9 { get; set; }
        public byte? Department10 { get; set; }
        public string OpeningMenu { get; set; }
        public int? TelecanvaserInd { get; set; }
        public int? AccountNumber { get; set; }
        public int? Status { get; set; }
        public string CreateSv { get; set; }
        public string AmendSv { get; set; }
        public DateTime? AmendDte { get; set; }
    }
}
