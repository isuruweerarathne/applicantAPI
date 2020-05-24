using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class AccountSuspendReact
    {
        public int SuspendReactId { get; set; }
        public int? AccountNumber { get; set; }
        public string Company { get; set; }
        public string AccountName { get; set; }
        public string AccountEmail { get; set; }
        public string AccountTelNo { get; set; }
        public int? CurrentStatus { get; set; }
        public int? NewStatus { get; set; }
        public string AmendSv { get; set; }
        public DateTime? Date { get; set; }
    }
}
