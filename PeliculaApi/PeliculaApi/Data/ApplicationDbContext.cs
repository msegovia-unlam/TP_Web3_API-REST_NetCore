using Microsoft.EntityFrameworkCore;
using PeliculaApi.Models;

namespace PeliculaApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
