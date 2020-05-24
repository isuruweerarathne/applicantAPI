using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class BillingRatePlans
    {
        public int RatePlanId { get; set; }
        public string Description { get; set; }
        public int? DefaultForType { get; set; }
        public int? BillingType { get; set; }
        public DateTime? Datecreated { get; set; }
        public string DateActivatedText { get; set; }
        public DateTime? DateActivated { get; set; }
        public string DateRetiredText { get; set; }
        public DateTime? DateRetired { get; set; }
        public string Svadd { get; set; }
        public string Svamend { get; set; }
    }
}
