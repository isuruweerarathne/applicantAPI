using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class VSlAllocationTrans
    {
        public int? AccountNo { get; set; }
        public decimal? Unallocated { get; set; }
        public int SltransNo { get; set; }
        public decimal? UnallocatedCredit { get; set; }
        public int UnallCrSltrans { get; set; }
    }
}
