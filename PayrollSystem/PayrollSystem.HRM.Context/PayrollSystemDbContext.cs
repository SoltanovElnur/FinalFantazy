using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PayrollSystem.HRM.Entity;

namespace PayrollSystem.HRM.Context
{
    public class PayrollSystemDbContext : IdentityDbContext<AplicationUser>
    {
        public PayrollSystemDbContext(DbContextOptions<PayrollSystemDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Bonus> Bonus { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyMonthlyGain> CMGains { get; set; }
        public DbSet<CompanyDepartment> CompanyDepartments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Holding> Holdings { get; set; }
        public DbSet<HoldingDepartment> HoldingDepartments { get; set; }
        public DbSet<Continuity> Continuity { get; set; }
        public DbSet<Penalty> Penals { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Vocation> Vocations { get; set; }
        public DbSet<WorkPlace> WorkPlaces { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AplicationUser>()
           .HasOne(a => a.Employee)
           .WithOne(b => b.AplicationUser)
           .HasForeignKey<AplicationUser>(b => b.EmployeeId);
            builder.Entity<CompanyDepartment>().HasKey(x => new { x.CompanyId, x.DepartmentId });
            builder.Entity<HoldingDepartment>().HasKey(y => new { y.HoldingId, y.DepartmentId });
        }
    }
}
