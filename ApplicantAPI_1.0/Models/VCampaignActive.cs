using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class VCampaignActive
    {
        public int CampaignId { get; set; }
        public int? Status { get; set; }
        public string Link { get; set; }
        public string CampaignQuestion1 { get; set; }
        public string CampaignQuestion2 { get; set; }
        public string CampaignQuestion3 { get; set; }
        public string CampaignQuestion4 { get; set; }
    }
}
