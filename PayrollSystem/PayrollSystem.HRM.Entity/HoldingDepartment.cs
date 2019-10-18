using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollSystem.HRM.Entity
{
    public class HoldingDepartment
    {
        public int HoldingId { get; set; }
        public virtual Holding Holding { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
