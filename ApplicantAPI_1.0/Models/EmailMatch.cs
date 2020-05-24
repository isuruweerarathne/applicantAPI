using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class EmailMatch
    {
        public int EmailMatchInd { get; set; }
        public int? SessVarInd { get; set; }
        public string EmailAdd { get; set; }
        public int? MaxEnqInd { get; set; }
        public int? Del { get; set; }
        public string UserName { get; set; }
    }
}
