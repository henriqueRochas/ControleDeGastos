using ControleDeGastos.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeGastos.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Categoria> Categorias => Set<Categoria>();
        public DbSet<Despesa> Despesas => Set<Despesa>();
    }
}
