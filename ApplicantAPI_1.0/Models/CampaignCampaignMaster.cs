using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class CampaignCampaignMaster
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public int? CompanyAccount { get; set; }
        public int? UserCreate { get; set; }
        public int? BillingType { get; set; }
        public string CompanyInternalReference { get; set; }
        public string AdvertTitle { get; set; }
        public int? RatePlan { get; set; }
        public decimal? SpendingCap { get; set; }
        public decimal? SpendToDate { get; set; }
        public int? NameInd { get; set; }
        public string CampaignQuestion1 { get; set; }
        public string CampaignQuestion2 { get; set; }
        public string CampaignQuestion3 { get; set; }
        public string CampaignQuestion4 { get; set; }
        public int? CampaignQuest { get; set; }
        public int? PosSelect { get; set; }
        public string PositionTitle { get; set; }
        public string ModelMbtifromTemplate { get; set; }
        public string ModelMbtifromAdvanced { get; set; }
        public int? ModelFfmeLow { get; set; }
        public int? ModelFfmeHigh { get; set; }
        public int? ModelFfmaLow { get; set; }
        public int? ModelFfmaHigh { get; set; }
        public int? ModelFfmnLow { get; set; }
        public int? ModelFfmnHigh { get; set; }
        public int? ModelFfmoLow { get; set; }
        public int? ModelFfmoHigh { get; set; }
        public int? ModelFfmcLow { get; set; }
        public int? ModelFfmcHigh { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? MaximumNoOfEntries { get; set; }
        public string DateClosedText { get; set; }
        public DateTime? DateClosed { get; set; }
        public string Link { get; set; }
        public int? Status { get; set; }
        public string CreateSv { get; set; }
        public string AmendSv { get; set; }
        public int? CampaignActive { get; set; }
    }
}
