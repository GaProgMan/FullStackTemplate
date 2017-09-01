using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FullStackTemplate.Entities;

namespace FullStackTemplate.Persistence
{
    public interface IFullStackTemplateContext
    {
        /// <summary>
        /// Asynchronously saves all changes made in the FullStackTemplateContext to the database.
        /// </summary>
        /// <param name="acceptAllChangesOnSuccess">
        ///     Indicates whether <see cref="M:Microsoft.EntityFrameworkCore.ChangeTracking.ChangeTracker.AcceptAllChanges" /> is called after the changes have
        ///     been sent successfully to the database.
        /// </param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        ///     A task that represents the asynchronous save operation. The task result contains the
        ///     number of state entries written to the database.
        /// </returns>
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess = true,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}