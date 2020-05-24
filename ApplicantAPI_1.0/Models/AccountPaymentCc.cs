using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class AccountPaymentCc
    {
        public int CcId { get; set; }
        public int? EnqInd { get; set; }
        public int? AccountId { get; set; }
        public string CcardName { get; set; }
        public string Ccnumber { get; set; }
        public int? ExpiryMm { get; set; }
        public int? ExpiryYy { get; set; }
        public string ExpiryTxt { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Cvctxt { get; set; }
        public int? Cvc { get; set; }
        public int? DateValid { get; set; }
        public int? Debit { get; set; }
        public int? Credit { get; set; }
        public string System { get; set; }
        public int? CheckSum { get; set; }
        public int? SameAddress { get; set; }
        public string CardAddr1 { get; set; }
        public string CardAdd2 { get; set; }
        public string CardCty { get; set; }
        public string CardPcode { get; set; }
        public int? CardValid { get; set; }
        public string NewSesVar { get; set; }
        public string AmendSesVar { get; set; }
        public int? PayMethodValid { get; set; }
    }
}
