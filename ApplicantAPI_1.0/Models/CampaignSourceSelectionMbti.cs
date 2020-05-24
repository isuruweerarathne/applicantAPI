using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class CampaignSourceSelectionMbti
    {
        public int? CampaignId { get; set; }
        public int? NameInd { get; set; }
        public string MbtiType { get; set; }
        public string MbtiDescr { get; set; }
        public int? Selected { get; set; }
    }
}
