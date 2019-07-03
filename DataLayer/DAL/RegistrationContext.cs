using DataLayer.Library;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.DAL
{
    public class RegistrationContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; } 
        public DbSet<Genre> Genres { get; set; }

        public RegistrationContext(DbContextOptions<RegistrationContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(p => p.Author)
                .WithMany(t => t.Books)
                .HasForeignKey(p => p.AuthorId);

            modelBuilder.Entity<Book>()
                .HasOne(p => p.Genre)
                .WithMany(t => t.Books)
                .HasForeignKey(p => p.GenreId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
