using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class VCampaignApplicantDash
    {
        public string PCent { get; set; }
        public string Nme { get; set; }
        public int? Campaign { get; set; }
        public int ApplicationId { get; set; }
        public string Cv { get; set; }
        public string CovL { get; set; }
        public string PsyR { get; set; }
        public decimal? PercentageFit { get; set; }
        public string CompanyName { get; set; }
    }
}
