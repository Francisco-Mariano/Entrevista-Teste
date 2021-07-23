using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using entrevista.Models;

namespace entrevista.Data
{
    public class entrevistaContext : DbContext
    {
        public entrevistaContext (DbContextOptions<entrevistaContext> options)
            : base(options)
        {
        }

        public DbSet<entrevista.Models.Entrevista> Entrevista { get; set; }
    }
}
