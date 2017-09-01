using FullStackTemplate.DAL;

namespace FullStackTemplate.Facade.ApiFacades
{
    public class DatabaseFacade : IDatabaseFacade
    {
        private readonly IDatabaseService _databaseService;

        public DatabaseFacade(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public bool ClearDatabase()
        {
            return _databaseService.ClearDatabase();
        }

        public int SeedDatabase()
        {
            return _databaseService.SeedDatabase();
        }
        
        public int GetRecordCount()
        {
            return _databaseService.GetEntityCount();
        }
    }
}