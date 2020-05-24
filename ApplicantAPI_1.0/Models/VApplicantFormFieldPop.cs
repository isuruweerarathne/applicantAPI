using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class VApplicantFormFieldPop
    {
        public int Pages { get; set; }
        public string Link { get; set; }
        public int CampaignId { get; set; }
        public int? CompanyAccount { get; set; }
        public string CompanyName { get; set; }
        public string AdvertTitle { get; set; }
        public string Para2 { get; set; }
        public string CampaignQuestion1 { get; set; }
        public string CampaignQuestion2 { get; set; }
        public string CampaignQuestion3 { get; set; }
        public string CampaignQuestion4 { get; set; }
        public int VacOpen { get; set; }
    }
}
