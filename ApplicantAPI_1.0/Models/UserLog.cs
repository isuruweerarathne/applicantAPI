using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class UserLog
    {
        public int LogInd { get; set; }
        public int? UserRegNo { get; set; }
        public int? AccountNumber { get; set; }
        public string Event { get; set; }
        public string SessVar { get; set; }
        public DateTime? Dte { get; set; }
        public bool? Display { get; set; }
        public short? LogType { get; set; }
        public string TableName { get; set; }
        public int? TableInd { get; set; }
    }
}
