using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TextbookFinder.Models;

namespace TextbookFinder.Controllers
{
    public class TextbookPublishersController : Controller
    {
        private readonly TextbooksDBContext _context;

        public TextbookPublishersController(TextbooksDBContext context)
        {
            _context = context;
        }

        // GET: TextbookPublishers
        public async Task<IActionResult> Index()
        {
            return View(await _context.TextbookPublishers.ToListAsync());
        }

        // GET: TextbookPublishers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textbookPublishers = await _context.TextbookPublishers
                .FirstOrDefaultAsync(m => m.PublisherId == id);
            if (textbookPublishers == null)
            {
                return NotFound();
            }

            return View(textbookPublishers);
        }

        // GET: TextbookPublishers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TextbookPublishers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PublisherId,PublisherName,PublisherWebsite")] TextbookPublishers textbookPublishers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(textbookPublishers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(textbookPublishers);
        }

        // GET: TextbookPublishers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textbookPublishers = await _context.TextbookPublishers.FindAsync(id);
            if (textbookPublishers == null)
            {
                return NotFound();
            }
            return View(textbookPublishers);
        }

        // POST: TextbookPublishers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PublisherId,PublisherName,PublisherWebsite")] TextbookPublishers textbookPublishers)
        {
            if (id != textbookPublishers.PublisherId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(textbookPublishers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TextbookPublishersExists(textbookPublishers.PublisherId))
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
            return View(textbookPublishers);
        }

        // GET: TextbookPublishers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textbookPublishers = await _context.TextbookPublishers
                .FirstOrDefaultAsync(m => m.PublisherId == id);
            if (textbookPublishers == null)
            {
                return NotFound();
            }

            return View(textbookPublishers);
        }

        // POST: TextbookPublishers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var textbookPublishers = await _context.TextbookPublishers.FindAsync(id);
            _context.TextbookPublishers.Remove(textbookPublishers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TextbookPublishersExists(int id)
        {
            return _context.TextbookPublishers.Any(e => e.PublisherId == id);
        }
    }
}
