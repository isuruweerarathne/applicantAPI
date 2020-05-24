using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class CampaignApplicantPayg
    {
        public int ApplicationId { get; set; }
        public string Link { get; set; }
        public int? Campaign { get; set; }
        public int? AccountNo { get; set; }
        public int? RatePlan { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CvfileName { get; set; }
        public string CovLettFileName { get; set; }
        public string CampaignQ1answer { get; set; }
        public string CampaignQ2answer { get; set; }
        public string CampaignQ3answer { get; set; }
        public string CampaignQ4answer { get; set; }
        public string IpaddrClientScreen { get; set; }
        public int? ReportPrintId { get; set; }
        public string Url { get; set; }
        public string Email { get; set; }
        public string TelNo { get; set; }
        public string TrueId { get; set; }
        public string Mbti { get; set; }
        public int? Ffme { get; set; }
        public int? Ffma { get; set; }
        public int? Ffmn { get; set; }
        public int? Ffmo { get; set; }
        public int? Ffmc { get; set; }
        public int? Gdprpermission { get; set; }
        public int? Delta { get; set; }
        public decimal? PercentageFit { get; set; }
        public DateTime? Datetime { get; set; }
        public string PsyReportFileName { get; set; }
    }
}
