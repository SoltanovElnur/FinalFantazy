using Microsoft.AspNetCore.Http;
using PayrollSystem.HRM.Entity.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollSystem.HRM.WEB.ViewModel
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Surname { get; set; }
        [Required, StringLength(50)]
        public string FatherName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        [Required, StringLength(60)]
        public string Adress { get; set; }
        [Required, StringLength(60)]
        public string RegisterAdress { get; set; }
        [Required]
        public string PassportId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public string PassportExpDate { get; set; }
        [Required, StringLength(60)]
        public string Education { get; set; }
        public MartialStatus MartialStatus { get; set; }
        public Gender Gender { get; set; }
        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile PhotoPath { get; set; }
    }
}
