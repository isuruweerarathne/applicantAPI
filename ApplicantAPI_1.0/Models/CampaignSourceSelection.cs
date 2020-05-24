using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class CampaignSourceSelection
    {
        public int CampaignId { get; set; }
        public int? NameInd { get; set; }
        public string MbtiType { get; set; }
        public string Source { get; set; }
        public string RoleName { get; set; }
        public int RoleInd { get; set; }
        public string Descr { get; set; }
        public int? Retain { get; set; }
        public int? Selected { get; set; }
        public string MbtiDescr { get; set; }
    }
}
