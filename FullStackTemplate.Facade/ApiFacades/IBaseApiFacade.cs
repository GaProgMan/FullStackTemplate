namespace FullStackTemplate.Facade.ApiFacades
{
    public interface IBaseApiFacade
    {
        string ApiUseageString();
        bool DropData();
        int SeedData();
    }
}