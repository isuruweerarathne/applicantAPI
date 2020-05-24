using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class VAccountGen
    {
        public int? AccountNumber { get; set; }
        public string CompanyName { get; set; }
        public string AccountContactName { get; set; }
        public string AccountContactEmail { get; set; }
        public string AccountContactTelNo { get; set; }
        public string Expr1 { get; set; }
        public int? SalesAgent { get; set; }
        public int? NoOfEmployees { get; set; }
        public string Status { get; set; }
        public string SalesAgentName { get; set; }
        public string Duration { get; set; }
    }
}
