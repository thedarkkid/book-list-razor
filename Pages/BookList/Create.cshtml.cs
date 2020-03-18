using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Book Book { get; set; }

        private readonly ApplicationDbContext _db;

        public CreateModel( ApplicationDbContext _db)
        {
            this._db = _db;
        }

        public void OnGet()
        {

        }
        
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
               await _db.Book.AddAsync(Book);
               await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();  
            }
        }
    }
}