using Factory.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Factory.Infrastructure
{
    public class FactoryContext : DbContext
    {
        public FactoryContext(DbContextOptions<FactoryContext> options) : base(options)
        { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<ComicFavorito> ComicFavorito { get; set; }
    }
}
