using System;
using System.Collections.Generic;

namespace ApplicantAPI_1._0.Models
{
    public partial class UserValidationDepartments
    {
        public short? DepartmentNumber { get; set; }
        public string Description { get; set; }
        public string Qualify { get; set; }
        public string NotQualify { get; set; }
    }
}
