using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class ReportMbti
    {
        public int RoleInd { get; set; }
        public string Key { get; set; }
        public int? ScaleNo { get; set; }
        public string MbtiAnalogue { get; set; }
        public string Description { get; set; }
    }
}
