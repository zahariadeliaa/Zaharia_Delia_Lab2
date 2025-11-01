using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Zaharia_Delia_Lab2.Data;
using Zaharia_Delia_Lab2.Models;

namespace Zaharia_Delia_Lab2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Zaharia_Delia_Lab2.Data.Zaharia_Delia_Lab2Context _context;

        public CreateModel(Zaharia_Delia_Lab2.Data.Zaharia_Delia_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["AuthorID"] = new SelectList(_context.Author, "ID", "LastName");
            ViewData["PublisherID"] = new SelectList(_context.Publisher, "ID", "PublisherName");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["AuthorID"] = new SelectList(_context.Author, "ID", "LastName", Book.AuthorID);
                ViewData["PublisherID"] = new SelectList(_context.Publisher, "ID", "PublisherName", Book.PublisherID);
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
