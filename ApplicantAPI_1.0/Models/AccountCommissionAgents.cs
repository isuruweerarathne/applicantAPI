using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class AccountCommissionAgents
    {
        public int SalesAgentId { get; set; }
        public string SalesAgentName { get; set; }
        public string EmployeeReference { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public int? MasterAgentId { get; set; }
        public decimal? CommissionRate { get; set; }
        public decimal? OverideRateToMasterAgent { get; set; }
        public string VatregNo { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
