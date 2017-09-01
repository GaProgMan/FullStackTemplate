using System.Diagnostics;
using FullStackTemplate.Facade.ViewModels.Shared;

namespace FullStackTemplate.Facade.FeatureFacades
{
    public class HomeFacade : IHomeFacade
    {
        public void Index()
        {
            
        }
        
        public void About()
        {
        }

        public void Contact()
        {
            
            
        }

        public ErrorViewModel Error(string currentActivityId, string traceIdentifier)
        {
            return new ErrorViewModel {RequestId = currentActivityId ?? traceIdentifier};
        }
    }
}