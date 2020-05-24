using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class VSlBalance
    {
        public int? AccountNo { get; set; }
        public int SltransNo { get; set; }
        public string Date { get; set; }
        public string CrTotal { get; set; }
        public string DrTotal { get; set; }
        public decimal? Total { get; set; }
        public decimal? Unallocated { get; set; }
        public string Trans { get; set; }
        public string File { get; set; }
    }
}
