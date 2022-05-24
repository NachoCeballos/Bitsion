using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PruebaTecnica.DataAccess.Common;
using PruebaTecnica.Entities;

namespace PruebaTecnica.DataAccess
{
    public class AppDbContext : DbContext
    {
        private readonly IAppSettings _appSettings;
        public AppDbContext(IAppSettings appSettings)
        {
            _appSettings = appSettings;
        }
        
        public AppDbContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = _appSettings.ConnectionString();
            optionsBuilder.UseSqlServer(connection);
        }
        public DbSet<Client> Clients { get; set; }
    }
}
