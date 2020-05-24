using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class ErrorLog
    {
        public int Id { get; set; }
        public string ErrorMessage { get; set; }
        public string LongMessage { get; set; }
        public string CreatedOn { get; set; }
    }
}
