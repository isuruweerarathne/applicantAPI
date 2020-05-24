using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class VCampaignQtyApplicant
    {
        public int? Account { get; set; }
        public int? CampaignMasterId { get; set; }
        public int? Applications { get; set; }
        public string SessionVariable { get; set; }
    }
}
