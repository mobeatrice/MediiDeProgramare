using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movila_Beatrice.Models;

namespace Movila_Beatrice.Data
{
    public class Movila_BeatriceContext : DbContext
    {
        public Movila_BeatriceContext (DbContextOptions<Movila_BeatriceContext> options)
            : base(options)
        {
        }

        public DbSet<Movila_Beatrice.Models.Book> Book { get; set; } = default!;

        public DbSet<Movila_Beatrice.Models.Publisher> Publisher { get; set; } = default!;

        public DbSet<Movila_Beatrice.Models.Category> Category { get; set; } = default!;
    }
}
