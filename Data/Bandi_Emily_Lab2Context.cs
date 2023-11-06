using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bandi_Emily_Lab2.Models;

namespace Bandi_Emily_Lab2.Data
{
    public class Bandi_Emily_Lab2Context : DbContext
    {
        public Bandi_Emily_Lab2Context (DbContextOptions<Bandi_Emily_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Bandi_Emily_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
