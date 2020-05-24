using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class BillingRateTable
    {
        public int RateTableId { get; set; }
        public int? RatePlanId { get; set; }
        public int? BillingType { get; set; }
        public int? BillingClass { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
