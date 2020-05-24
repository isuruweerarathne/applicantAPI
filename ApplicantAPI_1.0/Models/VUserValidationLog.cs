using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class VUserValidationLog
    {
        public int UserIndex { get; set; }
        public string Nme { get; set; }
        public int? AccountNumber { get; set; }
        public byte? Department8 { get; set; }
        public byte? Department9 { get; set; }
        public byte? Department10 { get; set; }
    }
}
