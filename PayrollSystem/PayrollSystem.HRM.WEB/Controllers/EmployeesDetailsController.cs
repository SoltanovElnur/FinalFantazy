using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PayrollSystem.HRM.Context;
using PayrollSystem.HRM.Entity;

namespace PayrollSystem.HRM.WEB.Controllers
{
    public class EmployeesDetailsController : Controller
    {
        private readonly PayrollSystemDbContext _context;

        public EmployeesDetailsController(PayrollSystemDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var employees = _context.Employees
                .Include(e => e.Attendances)
                .Include(e => e.Bonus)
                .Include(e => e.Penalty)
                .Include(e => e.WorkPlaces)
                .Include("WorkPlaces.Position")
                .Include("WorkPlaces.Position.Salaries");
            
            return View(await employees.ToListAsync());
        }
    }
}
