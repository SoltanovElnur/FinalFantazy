using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PayrollSystem.HRM.Entity
{
    public class Department
    {
        public Department()
        {
            Positions = new HashSet<Position>();
            HoldingDepartments = new HashSet<HoldingDepartment>();
            CompanyDepartments = new HashSet<CompanyDepartment>();

        }
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
        public virtual ICollection<HoldingDepartment> HoldingDepartments { get; set; }
        public virtual ICollection<CompanyDepartment> CompanyDepartments { get; set; }
    }
}
