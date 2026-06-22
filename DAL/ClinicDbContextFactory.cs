using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DAL
{
    public class ClinicDbContextFactory : IDesignTimeDbContextFactory<ClinicDbContext>
    {
        public ClinicDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ClinicDbContext>();
            optionsBuilder.UseSqlServer("Server=COMPLEX7\\MSSQLSERVER01;Database=ClinicManagementDB;Trusted_Connection=True;TrustServerCertificate=True;");
            return new ClinicDbContext(optionsBuilder.Options);
        }
    }
}
