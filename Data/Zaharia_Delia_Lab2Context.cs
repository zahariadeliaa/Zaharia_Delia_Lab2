using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zaharia_Delia_Lab2.Models;

namespace Zaharia_Delia_Lab2.Data
{
    public class Zaharia_Delia_Lab2Context : DbContext
    {
        public Zaharia_Delia_Lab2Context (DbContextOptions<Zaharia_Delia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Zaharia_Delia_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Zaharia_Delia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Zaharia_Delia_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
