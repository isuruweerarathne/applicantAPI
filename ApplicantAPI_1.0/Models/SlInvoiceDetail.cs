using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class SlInvoiceDetail
    {
        public int InvTransId { get; set; }
        public int? AccountNumber { get; set; }
        public int? InvNumber { get; set; }
        public int? CampaignId { get; set; }
        public int? ReportPrintId { get; set; }
        public string CampaignName { get; set; }
        public string ReportPrintCode { get; set; }
        public int? Rateplan { get; set; }
        public decimal? TransPrice { get; set; }
        public int? Done { get; set; }
    }
}
