using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class BfmMbtimaster
    {
        public int RoleInd { get; set; }
        public int? NameInd { get; set; }
        public string RoleName { get; set; }
        public string MbtiType { get; set; }
        public string Source { get; set; }
        public int? Industrial { get; set; }
        public int? MedicalAndCaring { get; set; }
        public int? Services { get; set; }
        public int? Banking { get; set; }
        public int? Commerce { get; set; }
        public int? Legal { get; set; }
        public int? Accounting { get; set; }
        public int? Construction { get; set; }
        public int? CreativeMedia { get; set; }
    }
}
