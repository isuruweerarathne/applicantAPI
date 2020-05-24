using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class Months
    {
        public int MonthId { get; set; }
        public int? MonthNumber { get; set; }
        public string MonthName { get; set; }
        public string MonthShortName { get; set; }
    }
}
