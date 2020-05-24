using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class ValidationVariable
    {
        public int SessVarInd { get; set; }
        public string UserInd { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public DateTime? DateTime { get; set; }
        public string SessionVariable { get; set; }
        public int? Active { get; set; }
        public byte? SecLevel { get; set; }
        public byte? Department1 { get; set; }
        public byte? Department2 { get; set; }
        public byte? Department3 { get; set; }
        public byte? Department4 { get; set; }
        public byte? Department5 { get; set; }
        public byte? Department6 { get; set; }
        public byte? Department7 { get; set; }
        public byte? Department8 { get; set; }
        public byte? Department9 { get; set; }
        public byte? Department10 { get; set; }
        public string ParentSessVar { get; set; }
        public int? Marker { get; set; }
    }
}
