using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PayrollSystem.HRM.Entity
{
    public class Holding
    {
        public Holding()
        {
            Companies = new HashSet<Company>();
            HoldingToDepartments = new HashSet<HoldingDepartment>();
        }
        public int Id { get; set; }
        [Required, StringLength(60)]
        public string Name { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<HoldingDepartment> HoldingToDepartments { get; set; }
    }
}
