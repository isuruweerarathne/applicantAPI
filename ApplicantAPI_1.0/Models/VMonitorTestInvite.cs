using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class VMonitorTestInvite
    {
        public int TestId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public int? ReportPrintId { get; set; }
        public string BfmTrueId { get; set; }
    }
}
