using PayrollSystem.HRM.Entity.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PayrollSystem.HRM.Entity
{
    public class Employee
    {
        public Employee()
        {
            WorkPlaces = new HashSet<WorkPlace>();
            Attendances = new HashSet<Attendance>();
            Bonus = new HashSet<Bonus>();
            Penalty = new HashSet<Penalty>();
            Wages = new HashSet<Wages>();
            Vocations = new HashSet<Vocation>();

        }
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Surname { get; set; }
        [Required, StringLength(50)]
        public string FatherName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Birthdate { get; set; }
        [Required, StringLength(60)]
        public string Adress { get; set; }
        [Required, StringLength(60)]
        public string RegisterAdress { get; set; }
        [Required]
        public string PassportId { get; set; }
        [Required]
        public string PassportExpDate { get; set; }
        [NotMapped]
        public decimal TotalSalary { get; set; }
        [Required, StringLength(60)]
        public string Education { get; set; }
        public MartialStatus MartialStatus { get; set; }
        public Gender Gender { get; set; }
        [StringLength(255)]
        [DataType(DataType.Upload)]
        public string PhotoPath { get; set; }
        public string AplicationUserId { get; set; }
        public AplicationUser AplicationUser { get; set; }


        public virtual ICollection<WorkPlace> WorkPlaces { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Bonus> Bonus { get; set; }
        public virtual ICollection<Penalty> Penalty { get; set; }
        public virtual ICollection<Wages> Wages { get; set; }
        public virtual ICollection<Vocation> Vocations { get; set; }

    }
}
