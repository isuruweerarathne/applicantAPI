using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class SlSalesCommissionRate
    {
        public int SlcommissionInd { get; set; }
        public string Descrip { get; set; }
        public decimal? Rate { get; set; }
        public int? Internal { get; set; }
    }
}
