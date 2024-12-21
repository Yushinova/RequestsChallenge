using Microsoft.EntityFrameworkCore;

namespace RequestsChallenge.Storage
{
    public class ApplicationDbContext : DbContext 
    {
        public required DbSet<RequestData> Requests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conf = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            string? connectionString = conf.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
