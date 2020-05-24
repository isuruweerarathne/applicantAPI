using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class AccountContractDuration
    {
        public int ContractDurationId { get; set; }
        public int? NoOfMonths { get; set; }
        public string Descr { get; set; }
    }
}
