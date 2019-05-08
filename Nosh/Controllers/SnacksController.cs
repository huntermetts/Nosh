using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nosh.Data;
using Nosh.Models;

namespace Nosh.Controllers
{
    public class SnacksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SnacksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Snacks
        public async Task<IActionResult> Index(string searchString)
        {
            var snacks = from s in _context.Snack
                         .Include(s => s.snackType)
                         .Include(s => s.vendingMachine)
                         select s
                         ;

            if (!String.IsNullOrEmpty(searchString))
            {
                snacks = snacks.Where(s => s.snackName.Contains(searchString));


                return View(await snacks.ToListAsync());
            }
            else
            {
                return View(await _context.Snack
                    .Include(s => s.snackType)
                    .Include(s => s.vendingMachine)

                    .ToListAsync());
            }
        }

        // GET: Snacks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var snack = await _context.Snack
                .Include(s => s.snackType)
                .Include(s => s.vendingMachine)
                
                .FirstOrDefaultAsync(m => m.id == id);
            if (snack == null)
            {
                return NotFound();
            }

            return View(snack);
        }

        // GET: Snacks/Create
        public IActionResult Create()
        {
            ViewData["SnackTypeId"] = new SelectList(_context.SnackType, "SnackTypeId", "snackTypeName");
            ViewData["VendingMachineId"] = new SelectList(_context.VendingMachine, "id", "vendingMachineName");
            return View();
        }

        // POST: Snacks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,snackName,snackPrice,snackCalories,vendingMachineId,SnackTypeId")] Snack snack)
        {
            if (ModelState.IsValid)
            {
                _context.Add(snack);
                //_context.Add(CreateSnack.VendingMachineSnacks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SnackTypeId"] = new SelectList(_context.SnackType, "SnackTypeId", "snackTypeName");
            ViewData["VendingMachineId"] = new SelectList(_context.VendingMachine, "id", "vendingMachineName");

            return View(snack);

        }

        // GET: Snacks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var snack = await _context.Snack.FindAsync(id);
            if (snack == null)
            {
                return NotFound();
            }
            ViewData["SnackTypeId"] = new SelectList(_context.SnackType, "SnackTypeId", "snackTypeName");
            ViewData["VendingMachineId"] = new SelectList(_context.VendingMachine, "id", "vendingMachineName");
            return View(snack);
        }

        // POST: Snacks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,snackName,snackPrice,snackCalories,vendingMachineId,SnackTypeId")] Snack snack)
        {
            if (id != snack.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(snack);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SnackExists(snack.id))
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
            ViewData["SnackTypeId"] = new SelectList(_context.SnackType, "SnackTypeId", "snackTypeName");
            ViewData["VendingMachineId"] = new SelectList(_context.VendingMachine, "id", "vendingMachineName");
            return View(snack);
        }

        // GET: Snacks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var snack = await _context.Snack
                .Include(s => s.snackType)
                .Include(s => s.vendingMachine)
                .FirstOrDefaultAsync(m => m.id == id)
                ;
            if (snack == null)
            {
                return NotFound();
            }
            ViewData["SnackTypeId"] = new SelectList(_context.SnackType, "SnackTypeId", "snackTypeName");
            ViewData["VendingMachineId"] = new SelectList(_context.VendingMachine, "id", "vendingMachineName");
            return View(snack);
            
        }

        // POST: Snacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var snack = await _context.Snack.FindAsync(id);
            _context.Snack.Remove(snack);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SnackExists(int id)
        {
            return _context.Snack.Any(e => e.id == id);
        }
    }
}
