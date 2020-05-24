using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class AccountContractRenew
    {
        public int ContractRenewId { get; set; }
        public int? AccountNumber { get; set; }
        public DateTime? DateExistingContractEnds { get; set; }
        public int? ExistingRatePlan { get; set; }
        public string DateNewContractStartsTxt { get; set; }
        public DateTime? DateNewContractStarts { get; set; }
        public int? SalesAgent { get; set; }
        public int? NewRatePlan { get; set; }
        public int? ContractDuration { get; set; }
    }
}
