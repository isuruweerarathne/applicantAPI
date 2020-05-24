using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class VSlDebits
    {
        public int SltransNo { get; set; }
        public int? AccountNo { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Unallocated { get; set; }
    }
}
