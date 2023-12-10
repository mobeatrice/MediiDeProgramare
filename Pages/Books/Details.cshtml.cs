using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Movila_Beatrice.Data;
using Movila_Beatrice.Models;

namespace Movila_Beatrice.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Movila_Beatrice.Data.Movila_BeatriceContext _context;

        public DetailsModel(Movila_Beatrice.Data.Movila_BeatriceContext context)
        {
            _context = context;
        }

      public Book Book { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
