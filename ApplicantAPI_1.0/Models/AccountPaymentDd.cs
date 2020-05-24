using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class AccountPaymentDd
    {
        public int DdId { get; set; }
        public int? EnqInd { get; set; }
        public int? AccountId { get; set; }
        public string AccountName { get; set; }
        public string BankName { get; set; }
        public string BankAddr1 { get; set; }
        public string BankCity { get; set; }
        public string BankPcode { get; set; }
        public string SortCode { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountNumber { get; set; }
        public string SignatureName { get; set; }
        public DateTime? SigDate { get; set; }
        public int? ValidAccount { get; set; }
        public string NewSesVar { get; set; }
        public string AmendSesVar { get; set; }
        public int? PayMethodValid { get; set; }
        public string DdmandateRef { get; set; }
    }
}
