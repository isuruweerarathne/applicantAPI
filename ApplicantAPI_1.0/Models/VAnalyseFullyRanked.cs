using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class VAnalyseFullyRanked
    {
        public int TestId { get; set; }
        public string Scale { get; set; }
        public double? Value { get; set; }
        public int Rnk { get; set; }
    }
}
