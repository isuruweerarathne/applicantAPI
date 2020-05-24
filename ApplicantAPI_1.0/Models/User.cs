using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public int? AccountNumber { get; set; }
        public int? Accounts { get; set; }
        public int? CreateVacancy { get; set; }
        public int? ViewProfiles { get; set; }
        public int? UserValidationInd { get; set; }
        public string CreateSv { get; set; }
        public int? Status { get; set; }
        public string AmendSv { get; set; }
    }
}
