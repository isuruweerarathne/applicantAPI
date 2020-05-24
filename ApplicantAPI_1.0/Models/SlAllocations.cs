using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class SlAllocations
    {
        public int SlallocationInd { get; set; }
        public int? SltransDr { get; set; }
        public decimal? SltransDrAmount { get; set; }
        public int? SltransCr { get; set; }
        public decimal? SlTransCrAmount { get; set; }
        public decimal? SltransNewDrAmount { get; set; }
        public decimal? SltransNewCrAmount { get; set; }
        public int? Done { get; set; }
    }
}
