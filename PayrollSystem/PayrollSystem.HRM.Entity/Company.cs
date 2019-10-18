using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PayrollSystem.HRM.Entity
{
    public class Company
    {
        public Company()
        {
            Branches = new HashSet<Branch>();
            Salaries = new HashSet<Salary>();
            CompanyDepartments = new HashSet<CompanyDepartment>();
        }
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public int HoldingId { get; set; }
        public virtual Holding Holding { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual ICollection<CompanyDepartment> CompanyDepartments { get; set; }
    }
}
