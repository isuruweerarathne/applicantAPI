using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class VCampaignCampaignDash
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public int? CompanyAccount { get; set; }
        public string CompanyInternalReference { get; set; }
        public string AdvertTitle { get; set; }
        public decimal? SpendingCap { get; set; }
        public decimal? SpendToDate { get; set; }
        public string CampaignQuestion1 { get; set; }
        public string CampaignQuestion2 { get; set; }
        public string CampaignQuestion3 { get; set; }
        public string CampaignQuestion4 { get; set; }
        public int? NameInd { get; set; }
        public string RoleName { get; set; }
        public string Dateclose { get; set; }
        public string AmendSv { get; set; }
        public int? CampaignActive { get; set; }
        public string Link { get; set; }
        public string DateClosedText { get; set; }
        public string SessionVariable { get; set; }
        public string CompanyName { get; set; }
    }
}
