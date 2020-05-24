using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class VAccountSetUpEmailCredentials
    {
        public int EnqInd { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}
