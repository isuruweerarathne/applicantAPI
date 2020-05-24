using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class CampaignRepPrint
    {
        public int ReportPrId { get; set; }
        public string Scale { get; set; }
        public double? Value { get; set; }
        public int Rnk { get; set; }
        public int TestId { get; set; }
        public string Plong { get; set; }
        public bool? Done { get; set; }
    }
}
