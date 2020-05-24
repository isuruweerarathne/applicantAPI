using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class VUserVal
    {
        public string UserInd { get; set; }
        public string SessionVariable { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int? AccountNumber { get; set; }
        public int UserIndex { get; set; }
        public string OpeningMenu { get; set; }
        public int? RatePlan { get; set; }
        public string CompanyName { get; set; }
        public int? BillingType { get; set; }
    }
}
