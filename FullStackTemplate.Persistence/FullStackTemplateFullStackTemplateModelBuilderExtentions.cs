using Microsoft.EntityFrameworkCore;
using FullStackTemplate.Entities;

namespace FullStackTemplate.Persistence
{
    public static class FullStackTemplateModelBuilderExtentions
    {
        /// <summary>
        /// Used to create the the primary keys for FullStackTemplate's database model
        /// </summary>
        /// <param name="builder">An instance of the <see cref="ModelBuilder"/> to act on</param>
        public static void AddPrimaryKeys(this ModelBuilder builder)
        {
            // TODO add primary keys here using the following format
            //builder.Entity<ClassName>().ToTable("ClassNames").HasKey(e => e.ClassNameId);
        }

        /// <summary>
        /// Used to create the Foreign keys for FullStackTemplate's database model
        /// </summary>
        /// <param name="builder">An instance of the <see cref="ModelBuilder"/> to act on</param>
        public static void AddForeignKeys(this ModelBuilder builder)
        {
            // TODO add foreign keys here using the following format
            //builder.Entity<ParentClassName>().HasMany(pcn => pcn.ChildClassNames).WithOne(ccn => ccn.ParentClass);
        }
    }
}