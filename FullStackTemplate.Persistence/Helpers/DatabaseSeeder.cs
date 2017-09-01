using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using FullStackTemplate.Entities;

namespace FullStackTemplate.Persistence.Helpers
{
    public class DatabaseSeeder
    {
        private readonly IFullStackTemplateContext _FullStackTemplateContext;

        public DatabaseSeeder(IFullStackTemplateContext FullStackTemplateContext)
        {
            _FullStackTemplateContext = FullStackTemplateContext;
        }

        // TODO Add methods which will seed the database
    }
}