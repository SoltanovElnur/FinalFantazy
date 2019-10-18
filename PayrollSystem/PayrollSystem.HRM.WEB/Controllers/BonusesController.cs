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
    public class BonusesController : Controller
    {
        private readonly PayrollSystemDbContext _context;

        public BonusesController(PayrollSystemDbContext context)
        {
            _context = context;
        }

        // GET: Bonuses
        public async Task<IActionResult> Index()
        {
            var payrollSystemDbContext = _context.Bonus.Include(b => b.Employee);
            return View(await payrollSystemDbContext.ToListAsync());
        }

        // GET: Bonuses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bonus = await _context.Bonus
                .Include(b => b.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bonus == null)
            {
                return NotFound();
            }

            return View(bonus);
        }

        // GET: Bonuses/Create
        public  IActionResult Create()
        {
            
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Amount,Reason,IsPayed,Date,EmployeeId")] Bonus bonus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bonus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Name", bonus.EmployeeId);
            return View(bonus);
        }

        // GET: Bonuses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bonus = await _context.Bonus.FindAsync(id);
            if (bonus == null)
            {
                return NotFound();
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Name", bonus.EmployeeId);
            return View(bonus);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Amount,Reason,IsPayed,Date,EmployeeId")] Bonus bonus)
        {
            if (id != bonus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bonus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BonusExists(bonus.Id))
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
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Name", bonus.EmployeeId);
            return View(bonus);
        }

        // GET: Bonuses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bonus = await _context.Bonus
                .Include(b => b.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bonus == null)
            {
                return NotFound();
            }

            return View(bonus);
        }

        // POST: Bonuses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bonus = await _context.Bonus.FindAsync(id);
            _context.Bonus.Remove(bonus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BonusExists(int id)
        {
            return _context.Bonus.Any(e => e.Id == id);
        }
    }
}
