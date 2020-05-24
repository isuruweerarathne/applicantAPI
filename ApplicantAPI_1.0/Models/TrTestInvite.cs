using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class TrTestInvite
    {
        public int TestId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string TelNo { get; set; }
        public string Url { get; set; }
        public int? ConfirmConsent { get; set; }
        public DateTime? DateTimeConsent { get; set; }
        public string IpaddrClientScreen { get; set; }
        public int? ReportPrintId { get; set; }
        public string BfmTrueId { get; set; }
        public int? CustomerAccount { get; set; }
    }
}
