using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class SlSalesLedger
    {
        public int SltransNo { get; set; }
        public string DocumentType { get; set; }
        public int? DocumentTypeNumber { get; set; }
        public int? AccountNo { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Dr { get; set; }
        public decimal? DrVat { get; set; }
        public decimal? DrTotal { get; set; }
        public decimal? Cr { get; set; }
        public decimal? CrVat { get; set; }
        public decimal? CrTotal { get; set; }
        public decimal? Unallocated { get; set; }
        public string File { get; set; }
    }
}
