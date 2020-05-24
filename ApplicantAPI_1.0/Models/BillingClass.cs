using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class BillingClass
    {
        public int BillingClass1 { get; set; }
        public int? BillingType { get; set; }
        public int? MinNoOfEmployees { get; set; }
        public int? MaxNoOfEmployees { get; set; }
        public int? MinTransactions { get; set; }
        public int? MaxTransactions { get; set; }
        public string BillingClassEffectiveDateTx { get; set; }
        public DateTime? BillingClassEffectiveDate { get; set; }
        public string BillingClassRetireDateTx { get; set; }
        public DateTime? BillingClassRetireDate { get; set; }
    }
}
