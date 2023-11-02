using GestionStock.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionStock2.Models
{
    public class GestionStockDBContext:DbContext
    {
        public GestionStockDBContext(DbContextOptions<GestionStockDBContext> options) : base(options)
        {
        }
        public DbSet<Categorias> Categorias => Set<Categorias>();

        public DbSet<Productos> Productos => Set<Productos>();
    }
}
