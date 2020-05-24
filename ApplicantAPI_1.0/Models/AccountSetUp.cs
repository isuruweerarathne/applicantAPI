using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class AccountSetUp
    {
        public int EnqInd { get; set; }
        public int? AccountNumber { get; set; }
        public string CompanyName { get; set; }
        public string AccountName { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string Pcode { get; set; }
        public string AccountTelNo { get; set; }
        public string CoReg { get; set; }
        public string VatReg { get; set; }
        public string SalesContactName { get; set; }
        public string SalesContactEmail { get; set; }
        public string SalesContactTelNo { get; set; }
        public string AccountContactName { get; set; }
        public string AccountContactEmail { get; set; }
        public string AccountContactTelNo { get; set; }
        public DateTime DateSigned { get; set; }
        public int? ContactDuration { get; set; }
        public int? ChangePayMethod { get; set; }
        public DateTime? ContractRenewalDate { get; set; }
        public int? CreditLimit { get; set; }
        public int? SalesAgent { get; set; }
        public int? AccountType { get; set; }
        public int? BillingType { get; set; }
        public int? BillingClass { get; set; }
        public int? UserValidInd { get; set; }
        public int? NoOfEmployees { get; set; }
        public int? SectorType { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? Status { get; set; }
        public DateTime? DateClosed { get; set; }
        public string NewSesVar { get; set; }
        public string AmendSesVar { get; set; }
        public int? RatePlan { get; set; }
        public DateTime? RatePlanDateStart { get; set; }
        public DateTime? RatePlanDateEnd { get; set; }
        public int? Vatrate { get; set; }
        public int? CreditCard { get; set; }
        public int? DirectDebit { get; set; }
    }
}
