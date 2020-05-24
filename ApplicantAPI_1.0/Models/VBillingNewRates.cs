using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class VBillingNewRates
    {
        public int? RatePlanId { get; set; }
        public string ClassDescr { get; set; }
        public decimal? Price { get; set; }
    }
}
