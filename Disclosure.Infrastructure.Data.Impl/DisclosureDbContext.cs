using System.Data.Entity;
using Disclosure.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace Disclosure.Infrastructure.Data.Impl
{
    public class DisclosureDbContext: DbContext
    {
        public DisclosureDbContext()
            : base("name=DisclosureDB")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewsEntity>().HasKey(x => x.Id);
            modelBuilder.Entity<NewsEntity>().Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


        }

        public DbSet<NewsEntity> News { get; set; }
    }
}
