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
    public class TextbookCategoriesController : Controller
    {
        private readonly TextbooksDBContext _context;

        public TextbookCategoriesController(TextbooksDBContext context)
        {
            _context = context;
        }

        // GET: TextbookCategories
        public async Task<IActionResult> Index()
        {
            var textbooksDBContext = _context.TextbookCategories.Include(t => t.Category).Include(t => t.Textbook);
            return View(await textbooksDBContext.ToListAsync());
        }

        // GET: TextbookCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textbookCategories = await _context.TextbookCategories
                .Include(t => t.Category)
                .Include(t => t.Textbook)
                .FirstOrDefaultAsync(m => m.TextbookId == id);
            if (textbookCategories == null)
            {
                return NotFound();
            }

            return View(textbookCategories);
        }

        // GET: TextbookCategories/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "Categories");
            ViewData["TextbookId"] = new SelectList(_context.Textbooks, "TextbookId", "Title");
            return View();
        }

        // POST: TextbookCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TextbookId,CategoryId")] TextbookCategories textbookCategories)
        {
            if (ModelState.IsValid)
            {
                _context.Add(textbookCategories);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "Categories", textbookCategories.CategoryId);
            ViewData["TextbookId"] = new SelectList(_context.Textbooks, "TextbookId", "Title", textbookCategories.TextbookId);
            return View(textbookCategories);
        }

        // GET: TextbookCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textbookCategories = await _context.TextbookCategories.FindAsync(id);
            if (textbookCategories == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "Categories", textbookCategories.CategoryId);
            ViewData["TextbookId"] = new SelectList(_context.Textbooks, "TextbookId", "Title", textbookCategories.TextbookId);
            return View(textbookCategories);
        }

        // POST: TextbookCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TextbookId,CategoryId")] TextbookCategories textbookCategories)
        {
            if (id != textbookCategories.TextbookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(textbookCategories);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TextbookCategoriesExists(textbookCategories.TextbookId))
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
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "Categories", textbookCategories.CategoryId);
            ViewData["TextbookId"] = new SelectList(_context.Textbooks, "TextbookId", "Title", textbookCategories.TextbookId);
            return View(textbookCategories);
        }

        // GET: TextbookCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textbookCategories = await _context.TextbookCategories
                .Include(t => t.Category)
                .Include(t => t.Textbook)
                .FirstOrDefaultAsync(m => m.TextbookId == id);
            if (textbookCategories == null)
            {
                return NotFound();
            }

            return View(textbookCategories);
        }

        // POST: TextbookCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var textbookCategories = await _context.TextbookCategories.FindAsync(id);
            _context.TextbookCategories.Remove(textbookCategories);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TextbookCategoriesExists(int id)
        {
            return _context.TextbookCategories.Any(e => e.TextbookId == id);
        }
    }
}
