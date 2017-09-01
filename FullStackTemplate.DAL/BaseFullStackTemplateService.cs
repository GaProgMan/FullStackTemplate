using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FullStackTemplate.Entities;
using FullStackTemplate.Persistence;

namespace FullStackTemplate.DAL
{
    public class BaseFullStackTemplateService : IBaseFullStackTemplateService
    {
        protected readonly FullStackTemplateContext _FullStackTemplateContext;

        public BaseFullStackTemplateService(FullStackTemplateContext FullStackTemplateContext)
        {
            _FullStackTemplateContext = FullStackTemplateContext;
        }

        /// <summary>
        /// Used to perform a trackable query on any dbset of entities which extend
        /// the <see cref="IBaseFullStackTemplateEntity" /> - i.e. any changes made to the context
        /// will be tracked.
        /// </summary>
        /// <param name="includeNavigationProperties">
        /// Indicates whether all navigation properties should be traversed in order
        /// to get all related entities
        /// </param>
        /// <returns>
        /// The set of all entities which match the passed in <see cref="T"/>
        /// with change tracking enabled
        /// </returns>
        public IEnumerable<T> BaseQuery<T>(bool includeNavigationProperties = false)
            where T : BaseFullStackTemplateEntity, new()
        {
            var query = _FullStackTemplateContext.Set<T>().AsQueryable();

            if (includeNavigationProperties)
            {
                query = query.IncludeAll<T>();
            }
            return query;
        }

        /// <summary>
        /// Used to perform a read only query on any dbset of entities which extend
        /// the <see cref="IBaseFullStackTemplateEntity" />.
        /// </summary>
        /// <param name="includeNavigationProperties">
        /// Indicates whether all navigation properties should be traversed in order
        /// to get all related entities
        /// </param>
        /// <returns>
        /// The set of all entities which match the passed in <see cref="T"/>
        /// with change tracking disabled
        /// </returns>
        public IEnumerable<T> BaseReadOnlyQuery<T>(bool includeNavigationProperties = false) where T : BaseFullStackTemplateEntity, new()
        {
            var query = _FullStackTemplateContext.Set<T>().AsNoTracking().AsQueryable();

            if (includeNavigationProperties)
            {
                query = query.IncludeAll<T>();
            }
            return query;
        }
    }
}