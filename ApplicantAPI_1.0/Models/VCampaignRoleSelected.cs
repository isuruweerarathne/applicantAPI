using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class VCampaignRoleSelected
    {
        public int CampaignId { get; set; }
        public string RoleName { get; set; }
        public int? NameInd { get; set; }
        public int Rank { get; set; }
    }
}
