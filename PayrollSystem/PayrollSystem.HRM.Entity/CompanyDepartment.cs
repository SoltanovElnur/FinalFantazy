using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollSystem.HRM.Entity
{
    public class CompanyDepartment
    {
        public virtual Company Company { get; set; }
        public int CompanyId { get; set; }

        public virtual Department Department { get; set; }
        public int DepartmentId { get; set; }
    }
}
