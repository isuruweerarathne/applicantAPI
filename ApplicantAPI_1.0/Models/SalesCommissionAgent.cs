using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class SalesCommissionAgent
    {
        public int SalesAgentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string Pcode { get; set; }
        public int? TrEmployee { get; set; }
        public string AccountTelNo { get; set; }
        public string SalesContactName { get; set; }
        public string SalesContactEmail { get; set; }
        public string SalesContactTelNo { get; set; }
        public string AccountContactName { get; set; }
        public string AccountContactEmail { get; set; }
        public string AccountContactTelNo { get; set; }
        public DateTime DateSigned { get; set; }
        public int? CommissionPlan { get; set; }
        public string BankAccountName { get; set; }
        public string SortCode { get; set; }
        public string AccountNo { get; set; }
        public string BankName { get; set; }
        public string Sv { get; set; }
        public string AgentEndDateTxt { get; set; }
        public DateTime? AgentEndDate { get; set; }
        public string CoNumber { get; set; }
        public string VatregNo { get; set; }
    }
}
