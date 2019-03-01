using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PruebaEF.Models
{
    public class PruebaEFContext : DbContext
    {
        public PruebaEFContext (DbContextOptions<PruebaEFContext> options)
            : base(options)
        {
        }

        public DbSet<PruebaEF.Models.Producto> Producto { get; set; }
        public DbSet<PruebaEF.Models.Categoria> Categoria { get; set; }
    }
}
