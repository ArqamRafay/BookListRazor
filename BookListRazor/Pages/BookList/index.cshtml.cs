using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Pages.BookList
{
    public class indexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public indexModel(ApplicationDbContext db) 
        {
            _db = db;

        }

        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
        {
            // Assign all of the book from the database
            Books = await _db.Book.ToListAsync();

        }
    }
}
