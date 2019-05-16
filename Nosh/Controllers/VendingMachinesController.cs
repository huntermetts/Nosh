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
    public class VendingMachinesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VendingMachinesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: VendingMachines
        public async Task<IActionResult> Index()
        {
            return View(await _context.VendingMachine
                //.Include(v => v.User)
                .ToListAsync());
        }

        // GET: VendingMachines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendingMachine = await _context.VendingMachine
                .FirstOrDefaultAsync(m => m.id == id);
            if (vendingMachine == null)
            {
                return NotFound();
            }

            return View(vendingMachine);
        }

        // GET: VendingMachines/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendingMachines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,vendingMachineName,vendingMachineLocation")] VendingMachine vendingMachine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendingMachine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendingMachine);
        }

        // GET: VendingMachines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendingMachine = await _context.VendingMachine.FindAsync(id);
            if (vendingMachine == null)
            {
                return NotFound();
            }
            return View(vendingMachine);
        }

        // POST: VendingMachines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,vendingMachineName,vendingMachineLocation")] VendingMachine vendingMachine)
        {
            if (id != vendingMachine.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendingMachine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendingMachineExists(vendingMachine.id))
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
            return View(vendingMachine);
        }

        // GET: VendingMachines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendingMachine = await _context.VendingMachine
                .Include(v => v.Snack)
                .FirstOrDefaultAsync(m => m.id == id);
            if (vendingMachine == null)
            {
                return NotFound();
            }

            return View(vendingMachine);
        }

        // POST: VendingMachines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var vendingMachine = await _context.VendingMachine
                .Include(v => v.Snack)
                .FirstOrDefaultAsync(v => v.id == id);



            if (vendingMachine.Snack.Count == 0) {
                _context.VendingMachine.Remove(vendingMachine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            } else
            {
                return RedirectToAction(nameof(DeleteRedirect));
            }
           

        }
    

        private bool VendingMachineExists(int id)
        {
            return _context.VendingMachine.Any(e => e.id == id);
        }




        public async Task<IActionResult> DeleteRedirect()
        {
            return View(await _context.VendingMachine.ToListAsync());
        }
    }
}
