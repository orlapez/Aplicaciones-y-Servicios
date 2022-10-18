using MedFlix.Entidades;
using Microsoft.EntityFrameworkCore;

namespace MedFlix.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Genero> Generos { get; set; }

    }
}
