using Microsoft.Extensions.Configuration;

namespace PruebaTecnica.DataAccess.Common
{
    public class AppSettings : IAppSettings
    {
        private readonly IConfiguration _configuration;
        public AppSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string ConnectionString()
        {
            return _configuration.GetConnectionString("connection");
        }
    }
}
