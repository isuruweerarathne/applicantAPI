using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class SlVatrates
    {
        public int VatRateId { get; set; }
        public string Descr { get; set; }
        public string InvoiceDescr { get; set; }
        public decimal? Rate { get; set; }
    }
}
