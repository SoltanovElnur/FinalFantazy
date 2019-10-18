using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PayrollSystem.HRM.Entity
{
    public class AplicationUser : IdentityUser
    {
        [Required]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
