using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using FullStackTemplate.Config;

namespace FullStackTemplate.Persistence
{
    /// <summary>
    /// This factory is provided so that the EF Core tools can build a full context
    /// without having to have access to where the DbContext is being created (i.e.
    /// in the UI layer).
    /// </summary>
    /// <remarks>
    /// Please see the following URL for more information:
    /// https://docs.microsoft.com/en-us/ef/core/miscellaneous/configuring-dbcontext#using-idbcontextfactorytcontext
    /// </remarks>
    public class FullStackTemplateContextFactory : IDesignTimeDbContextFactory<FullStackTemplateContext>
    {
        private static string DbConnectionString => new DatabaseConfiguration().GetDatabaseConnectionString();
        
        public FullStackTemplateContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FullStackTemplateContext>();
            
            optionsBuilder.UseSqlite(DbConnectionString);
            
            return new FullStackTemplateContext(optionsBuilder.Options);
        }
    }
}