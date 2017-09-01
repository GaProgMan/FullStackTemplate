namespace FullStackTemplate.Facade.ApiFacades
{
    public interface IDatabaseFacade
    {
        bool ClearDatabase();

        int SeedDatabase();
        
        int GetRecordCount();
    }
}