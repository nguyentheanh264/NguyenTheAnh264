using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenTheAnh0264.Models;

namespace NguyenTheAnh264.Controllers
{
    public class NguyenTheAnh0264Controller : Controller
    {
        private readonly ApplicationContext _context;

        public NguyenTheAnh0264Controller(ApplicationContext context)
        {
            _context = context;
        }

        // GET: NguyenTheAnh0264
        public async Task<IActionResult> Index()
        {
            return View(await _context.NTA0264.ToListAsync());
        }

        // GET: NguyenTheAnh0264/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTA0264 = await _context.NTA0264
                .FirstOrDefaultAsync(m => m.NTAId == id);
            if (nTA0264 == null)
            {
                return NotFound();
            }

            return View(nTA0264);
        }

        // GET: NguyenTheAnh0264/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NguyenTheAnh0264/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NTAId,NTAName,NTAGender")] NTA0264 nTA0264)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTA0264);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTA0264);
        }

        // GET: NguyenTheAnh0264/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTA0264 = await _context.NTA0264.FindAsync(id);
            if (nTA0264 == null)
            {
                return NotFound();
            }
            return View(nTA0264);
        }

        // POST: NguyenTheAnh0264/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NTAId,NTAName,NTAGender")] NTA0264 nTA0264)
        {
            if (id != nTA0264.NTAId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTA0264);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTA0264Exists(nTA0264.NTAId))
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
            return View(nTA0264);
        }

        // GET: NguyenTheAnh0264/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTA0264 = await _context.NTA0264
                .FirstOrDefaultAsync(m => m.NTAId == id);
            if (nTA0264 == null)
            {
                return NotFound();
            }

            return View(nTA0264);
        }

        // POST: NguyenTheAnh0264/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nTA0264 = await _context.NTA0264.FindAsync(id);
            _context.NTA0264.Remove(nTA0264);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTA0264Exists(int id)
        {
            return _context.NTA0264.Any(e => e.NTAId == id);
        }
    }
}
