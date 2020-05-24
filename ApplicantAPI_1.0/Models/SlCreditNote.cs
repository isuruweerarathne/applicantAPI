using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class SlCreditNote
    {
        public int CreditNoteInd { get; set; }
        public int? AccountNo { get; set; }
        public string AccountName { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string Pcode { get; set; }
        public string AccountsName { get; set; }
        public string AccountsEmail { get; set; }
        public DateTime? DateCrNote { get; set; }
        public decimal? Net { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Total { get; set; }
        public int? AllocAgainstSltransNo { get; set; }
        public int? SltransNo { get; set; }
        public string Sv { get; set; }
    }
}
