using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Movila_Beatrice.Data;
using Movila_Beatrice.Models;

namespace Movila_Beatrice.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Movila_Beatrice.Data.Movila_BeatriceContext _context;

        public IndexModel(Movila_Beatrice.Data.Movila_BeatriceContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
