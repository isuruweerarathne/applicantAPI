﻿using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class CampaignReportPrint
    {
        public int ReportId { get; set; }
        public int? Account { get; set; }
        public int? CampaignMasterId { get; set; }
        public int? CampaignMasterSerial { get; set; }
        public string Link { get; set; }
        public int? TestId { get; set; }
        public string L1 { get; set; }
        public string L2 { get; set; }
        public string L3 { get; set; }
        public string L4 { get; set; }
        public string L5 { get; set; }
        public string S1 { get; set; }
        public string S2 { get; set; }
        public string S3 { get; set; }
        public string S4 { get; set; }
        public string S5 { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string DteTime { get; set; }
        public int? E { get; set; }
        public int? A { get; set; }
        public int? N { get; set; }
        public int? O { get; set; }
        public int? C { get; set; }
        public string MbtiType { get; set; }
        public string MbtiAnalys { get; set; }
        public int? RatePlan { get; set; }
        public int? BillingClass { get; set; }
        public decimal? Price { get; set; }
        public DateTime? NextBillingDate { get; set; }
        public int? InvoiceNumber { get; set; }
        public int? CreditNoteNumber { get; set; }
        public int? Retain { get; set; }
        public string PdffileName { get; set; }
    }
}
