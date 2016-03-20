using System.Data.Entity;
using Disclosure.Domain;

namespace Disclosure.Infrastructure.Data.Impl
{
    public class DisclosureDbContext: DbContext
    {
        public DisclosureDbContext()
            : base("name=DisclosureDB")
        {
        }

        public DbSet<NewsEntity> News { get; set; }
    }
}
