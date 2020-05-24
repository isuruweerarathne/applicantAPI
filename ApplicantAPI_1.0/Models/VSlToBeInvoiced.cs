using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class VSlToBeInvoiced
    {
        public int? Account { get; set; }
        public DateTime? NextBillingDate { get; set; }
        public decimal? Net { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Total { get; set; }
        public decimal? Rate { get; set; }
    }
}
