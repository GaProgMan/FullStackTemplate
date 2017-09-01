using FullStackTemplate.Facade.ViewModels.Shared;

namespace FullStackTemplate.Facade.FeatureFacades
{
    public interface IHomeFacade
    {
        void Index();
        void About();
        void Contact();
        ErrorViewModel Error(string currentActivityId, string traceIdentifier);
    }
}