using System.Linq;
using Microsoft.EntityFrameworkCore;
using FullStackTemplate.Entities;

namespace FullStackTemplate.DAL
{
    public static class IQueryableExtensions
    {
        /// <summary>
        /// Used to ensure that all virtual navigation properties are included in any
        /// queries which are run against the <see cref="IQueryable" /> which it is called
        /// on.
        /// 
        /// </summary>
        /// <param name="queryable"></param>
        /// <returns></returns>
        /// <remarks>
        /// This method is adapted from the following answer on the Code Review Stack Exchange
        /// https://codereview.stackexchange.com/a/30867
        /// The original author is Stack Exchange user martijnlentink 
        /// </remarks>
        public static IQueryable<T> IncludeAll<T>(this IQueryable<T> queryable)
            where T : BaseFullStackTemplateEntity, new()
        {
            var type = typeof(T);
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                var isVirtual = property.GetGetMethod().IsVirtual;
                if (isVirtual && properties.FirstOrDefault(c => c.Name == property.Name + "Id") != null)
                {
                    queryable = queryable.Include(property.Name);
                }
            }
            return queryable;
        }
    }
}