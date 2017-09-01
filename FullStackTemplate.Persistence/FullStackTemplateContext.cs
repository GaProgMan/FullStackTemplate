using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FullStackTemplate.Entities;

namespace FullStackTemplate.Persistence
{
    public class FullStackTemplateContext : DbContext, IFullStackTemplateContext
    {
        public FullStackTemplateContext(DbContextOptions<FullStackTemplateContext> options) : base(options) { }

        public FullStackTemplateContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddPrimaryKeys();
            
            modelBuilder.AddForeignKeys();
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess = true,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            ChangeTracker.ApplyAuditInformation();
            
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}