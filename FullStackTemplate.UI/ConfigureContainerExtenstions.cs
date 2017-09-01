using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FullStackTemplate.Config;
using FullStackTemplate.DAL;
using FullStackTemplate.Facade.ApiFacades;
using FullStackTemplate.Facade.FeatureFacades;
using FullStackTemplate.Persistence;

namespace FullStackTemplate.UI
{
    /// <summary>
    /// This class is based on some of the suggestions bty K. Scott Allen in
    /// his NDC 2017 talk https://www.youtube.com/watch?v=6Fi5dRVxOvc
    /// </summary>
    public static class ConfigureContainerExtenstions
    {
        private static string DbConnectionString => new DatabaseConfiguration().GetDatabaseConnectionString();

        /// <summary>
        /// Adds the DbContext to ASP.NET Core's service collection. 
        /// </summary>
        /// <param name="serviceCollection">
        /// The <see cref="IServiceCollection"/> created in <see cref="Startup.ConfigureServices"/>
        /// </param>
        /// <param name="connectionString">
        /// (OPTIONAL) The connection string to use.
        /// </param>
        /// <remarks>
        /// If no connection string is supplied
        /// <see cref="FullStackTemplate.Config.DatabaseConfiguration"/> will be used to get the
        /// DbContext from the App.Config file
        /// </remarks>
        public static void AddDbContext(this IServiceCollection serviceCollection,
            string connectionString = null)
        {
            serviceCollection.AddDbContext<FullStackTemplateContext>(options =>
                options.UseSqlite(connectionString ?? DbConnectionString));
        }

        /// <summary>
        /// Adds all transient services into .NET Core's Dependency Injection service
        /// </summary>
        /// <param name="serviceCollection">
        /// The <see cref="IServiceCollection"/> created in <see cref="Startup.ConfigureServices"/>
        /// </param>
        public static void AddTransientServices(this IServiceCollection serviceCollection)
        {
            // TODO add more tansient services here
            serviceCollection.AddTransient<IDatabaseService, DatabaseService>();
        }
        
        /// <summary>
        /// Adds all transient facades into .NET Core's Dependency Injection Service
        /// </summary>
        /// <param name="serviceCollection"></param>
        public static void AddFacades(this IServiceCollection serviceCollection)
        {
            // TODO add more transient facades here
            // Api Facades
            serviceCollection.AddTransient<IBaseApiFacade, BaseApiFacade>();
            serviceCollection.AddTransient<IDatabaseFacade, DatabaseFacade>();

            // Feature Facades
            serviceCollection.AddTransient<IHomeFacade, HomeFacade>();
        }

        /// <summary>
        /// Adds MVC to ASP.NET Core's service collection
        /// </summary>
        /// <param name="serviceCollection">
        /// The <see cref="IServiceCollection"/> created in <see cref="Startup.ConfigureServices"/>
        /// </param>
        public static void AddCustomizedMvc(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvc();
        }

        /// <summary>
        /// Adds rules to the <see cref="RazorViewEngineOptions"/> for dealing with Feature Folders
        /// </summary>
        /// <param name="serviceCollection">
        /// The <see cref="IServiceCollection"/> created in <see cref="Startup.ConfigureServices"/>
        /// </param>
        public static void AddFeatureFolders(this IServiceCollection serviceCollection)
        {
            serviceCollection.Configure<RazorViewEngineOptions>(options =>
            {
                options.ViewLocationExpanders.Add(new FeatureLocationExpander());
            });
        }
    }
}