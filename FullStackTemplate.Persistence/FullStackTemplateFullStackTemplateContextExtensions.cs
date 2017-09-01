using FullStackTemplate.Persistence.Helpers;

namespace FullStackTemplate.Persistence
{
    public static class FullStackTemplateContextExtensions
    {
        public static int SeedDatabase(this FullStackTemplateContext FullStackTemplateContext)
        {
            var dbSeeder = new DatabaseSeeder(FullStackTemplateContext);

            // TODO capture the output of the dbSeeder method calls and sum them before returning
            return default(int);
        }
    }
}