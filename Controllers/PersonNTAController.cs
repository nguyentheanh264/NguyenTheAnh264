using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCPerson.Models;

namespace NguyenTheAnh264.Controllers
{
    public class PersonNTAController : Controller
    {
        private readonly ApplicationContext _context;

        public PersonNTAController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: PersonNTA
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonNTA264.ToListAsync());
        }

        // GET: PersonNTA/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNTA264 = await _context.PersonNTA264
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personNTA264 == null)
            {
                return NotFound();
            }

            return View(personNTA264);
        }

        // GET: PersonNTA/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonNTA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonNTA264 personNTA264)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personNTA264);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personNTA264);
        }

        // GET: PersonNTA/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNTA264 = await _context.PersonNTA264.FindAsync(id);
            if (personNTA264 == null)
            {
                return NotFound();
            }
            return View(personNTA264);
        }

        // POST: PersonNTA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonId,PersonName")] PersonNTA264 personNTA264)
        {
            if (id != personNTA264.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personNTA264);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonNTA264Exists(personNTA264.PersonId))
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
            return View(personNTA264);
        }

        // GET: PersonNTA/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNTA264 = await _context.PersonNTA264
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personNTA264 == null)
            {
                return NotFound();
            }

            return View(personNTA264);
        }

        // POST: PersonNTA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personNTA264 = await _context.PersonNTA264.FindAsync(id);
            _context.PersonNTA264.Remove(personNTA264);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonNTA264Exists(int id)
        {
            return _context.PersonNTA264.Any(e => e.PersonId == id);
        }
    }
}
