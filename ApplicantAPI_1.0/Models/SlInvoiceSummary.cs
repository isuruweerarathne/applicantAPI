using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class SlInvoiceSummary
    {
        public int SlInvNo { get; set; }
        public int? AccountNo { get; set; }
        public string AccountName { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string Pcode { get; set; }
        public string AccountsEmail { get; set; }
        public DateTime? InvDate { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? Vat { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? SltransNo { get; set; }
        public int? Done { get; set; }
    }
}
