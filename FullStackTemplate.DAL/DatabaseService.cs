using System.Linq;
using FullStackTemplate.Persistence;

namespace FullStackTemplate.DAL
{
    public class DatabaseService : IDatabaseService
    {
        private readonly FullStackTemplateContext _FullStackTemplateContext;

        public DatabaseService(FullStackTemplateContext FullStackTemplateContext)
        {
            _FullStackTemplateContext = FullStackTemplateContext;
        }

        public bool ClearDatabase()
        {
            var cleared = _FullStackTemplateContext.Database.EnsureDeleted();
            var created = _FullStackTemplateContext.Database.EnsureCreated();
            var entitiesadded = _FullStackTemplateContext.SaveChangesAsync(true).Result;

            return (cleared && created && entitiesadded == 0);
        }

        public int SeedDatabase()
        {
            return _FullStackTemplateContext.SeedDatabase();
        }

        public int GetEntityCount()
        {
            // TODO sum the total number of entities
            return default(int);
        }
    }
}