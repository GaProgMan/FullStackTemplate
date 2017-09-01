using System.Collections.Generic;
using FullStackTemplate.Entities;

namespace FullStackTemplate.DAL
{
    public interface IBaseFullStackTemplateService
    {
        IEnumerable<T> BaseQuery<T>(bool includeNavigationProperties = false)
            where T : BaseFullStackTemplateEntity, new();

        IEnumerable<T> BaseReadOnlyQuery<T>(bool includeNavigationProperties = false)
            where T : BaseFullStackTemplateEntity, new();
    }
}