using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Movila_Beatrice.Data;
using Movila_Beatrice.Models;

namespace Movila_Beatrice.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Movila_Beatrice.Data.Movila_BeatriceContext _context;

        public IndexModel(Movila_Beatrice.Data.Movila_BeatriceContext context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
