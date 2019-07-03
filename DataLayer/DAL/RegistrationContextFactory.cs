using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataLayer.DAL
{
    class RegistrationContextFactory : IDesignTimeDbContextFactory<RegistrationContext>
    {
        public RegistrationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RegistrationContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyLibrary;Trusted_Connection=True;MultipleActiveResultSets=true", b => b.MigrationsAssembly("DataLayer"));

            return new RegistrationContext(optionsBuilder.Options);
        }
    }
}
