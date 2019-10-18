using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PayrollSystem.HRM.Context;
using PayrollSystem.HRM.Entity;
using PayrollSystem.HRM.Entity.Extantions;
using PayrollSystem.HRM.WEB.ViewModel;


namespace PayrollSystem.HRM.WEB.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly PayrollSystemDbContext _context;
        private readonly IHostingEnvironment _env;
        private readonly UserManager<AplicationUser> _userManager;

        public EmployeesController(PayrollSystemDbContext context, IHostingEnvironment env, UserManager<AplicationUser> userManager)
        {
            _context = context;
            _env = env;
            _userManager = userManager;
        }
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }
        
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeViewModel employee)
        {
            if (ModelState.IsValid)
            {
                Employee emp = new Employee();
                if (employee.PhotoPath != null)
                {
                    emp.PhotoPath = await employee.PhotoPath.SaveFile(_env.WebRootPath.ToString());
                }
                else
                {
                    emp.PhotoPath = "no-image.jpg";
                }
                emp.Name = employee.Name;
                emp.Surname = employee.Surname;
                emp.FatherName = employee.FatherName;
                emp.Birthdate = employee.Birthdate;
                emp.Adress = employee.Adress;
                emp.RegisterAdress = employee.RegisterAdress;
                emp.PassportId = employee.PassportId;
                emp.PassportExpDate = employee.PassportExpDate;
                emp.Education = employee.Education;
                emp.MartialStatus = employee.MartialStatus;
                emp.Gender = employee.Gender;
                await _context.AddAsync(emp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }
        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,EmployeeViewModel employee)
        {
            Employee editUser = await _context.Employees.FindAsync(id);
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (employee.PhotoPath != null && editUser.PhotoPath != "no-image.jpg")
            {
                string filePath = Path.Combine(_env.WebRootPath, "images");
                string fullPathDelete = Path.Combine(filePath, editUser.PhotoPath);
                System.IO.File.Delete(fullPathDelete);
            }

            editUser.PhotoPath = await employee.PhotoPath.SaveFile(_env.WebRootPath.ToString());
            editUser.Name = employee.Name;
            editUser.Surname = employee.Surname;
            editUser.FatherName = employee.FatherName;
            editUser.Birthdate = employee.Birthdate;
            editUser.Adress = employee.Adress;
            editUser.RegisterAdress = employee.RegisterAdress;
            editUser.PassportId = employee.PassportId;
            editUser.PassportExpDate = employee.PassportExpDate;
            editUser.Education = employee.Education;
            editUser.MartialStatus = employee.MartialStatus;
            editUser.Gender = employee.Gender;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(editUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(editUser.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(editUser);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);

            string fullPath = Path.Combine(_env.WebRootPath, "images", employee.PhotoPath);
            if (System.IO.File.Exists(fullPath) && employee.PhotoPath != "no-image.jpg")
            {
                System.IO.File.Delete(fullPath);
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}
