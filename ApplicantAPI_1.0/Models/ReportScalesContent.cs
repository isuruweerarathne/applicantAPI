using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class ReportScalesContent
    {
        public int ScaleContentId { get; set; }
        public int? PsyScale { get; set; }
        public string Scale { get; set; }
        public double? Key { get; set; }
        public string PersonalityShort { get; set; }
        public string PersonalityLong { get; set; }
        public string DecisionMaking { get; set; }
        public string ReactionToStressAndUncertainty { get; set; }
    }
}
