using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class VBillingAmendRatePlan
    {
        public int? DefaultForType { get; set; }
        public string Description { get; set; }
        public DateTime? DateRetired { get; set; }
        public int RatePlanId { get; set; }
        public string PlanName { get; set; }
        public string DateRetiredText { get; set; }
        public string Svamend { get; set; }
    }
}
