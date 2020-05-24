using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class SlDebit
    {
        public int SldrInd { get; set; }
        public int? AccountNo { get; set; }
        public string AccountName { get; set; }
        public string AccountsName { get; set; }
        public string AccountsEmail { get; set; }
        public string Reference { get; set; }
        public DateTime? DateJr { get; set; }
        public decimal? Amount { get; set; }
        public int? AllocAgainstSltransNo { get; set; }
        public int? SltransNo { get; set; }
        public string Sv { get; set; }
    }
}
