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
    public class TextbookAuthorsController : Controller
    {
        private readonly TextbooksDBContext _context;

        public TextbookAuthorsController(TextbooksDBContext context)
        {
            _context = context;
        }

        // GET: TextbookAuthors
        public async Task<IActionResult> Index()
        {
            var textbooksDBContext = _context.TextbookAuthors.Include(t => t.Author).Include(t => t.Textbook);
            return View(await textbooksDBContext.ToListAsync());
        }

        // GET: TextbookAuthors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textbookAuthors = await _context.TextbookAuthors
                .Include(t => t.Author)
                .Include(t => t.Textbook)
                .FirstOrDefaultAsync(m => m.TextbookId == id);
            if (textbookAuthors == null)
            {
                return NotFound();
            }

            return View(textbookAuthors);
        }

        // GET: TextbookAuthors/Create
        public IActionResult Create()
        {
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "FirstName");
            ViewData["TextbookId"] = new SelectList(_context.Textbooks, "TextbookId", "Title");
            return View();
        }

        // POST: TextbookAuthors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TextbookId,AuthorId")] TextbookAuthors textbookAuthors)
        {
            if (ModelState.IsValid)
            {
                _context.Add(textbookAuthors);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "FirstName", textbookAuthors.AuthorId);
            ViewData["TextbookId"] = new SelectList(_context.Textbooks, "TextbookId", "Title", textbookAuthors.TextbookId);
            return View(textbookAuthors);
        }

        // GET: TextbookAuthors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textbookAuthors = await _context.TextbookAuthors.FindAsync(id);
            if (textbookAuthors == null)
            {
                return NotFound();
            }
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "FirstName", textbookAuthors.AuthorId);
            ViewData["TextbookId"] = new SelectList(_context.Textbooks, "TextbookId", "Title", textbookAuthors.TextbookId);
            return View(textbookAuthors);
        }

        // POST: TextbookAuthors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TextbookId,AuthorId")] TextbookAuthors textbookAuthors)
        {
            if (id != textbookAuthors.TextbookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(textbookAuthors);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TextbookAuthorsExists(textbookAuthors.TextbookId))
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
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "FirstName", textbookAuthors.AuthorId);
            ViewData["TextbookId"] = new SelectList(_context.Textbooks, "TextbookId", "Title", textbookAuthors.TextbookId);
            return View(textbookAuthors);
        }

        // GET: TextbookAuthors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textbookAuthors = await _context.TextbookAuthors
                .Include(t => t.Author)
                .Include(t => t.Textbook)
                .FirstOrDefaultAsync(m => m.TextbookId == id);
            if (textbookAuthors == null)
            {
                return NotFound();
            }

            return View(textbookAuthors);
        }

        // POST: TextbookAuthors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var textbookAuthors = await _context.TextbookAuthors.FindAsync(id);
            _context.TextbookAuthors.Remove(textbookAuthors);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TextbookAuthorsExists(int id)
        {
            return _context.TextbookAuthors.Any(e => e.TextbookId == id);
        }
    }
}
