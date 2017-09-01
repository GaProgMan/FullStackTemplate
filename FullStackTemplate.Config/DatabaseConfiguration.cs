using Microsoft.Extensions.Configuration;

namespace FullStackTemplate.Config
{
    public class DatabaseConfiguration : ConfigurationBase
    {
        private string DbConectionString = "FullStackTemplateDb";
        public string GetDatabaseConnectionString()
        {
            return GetConfiguration().GetConnectionString(DbConectionString);
        }
    }
}