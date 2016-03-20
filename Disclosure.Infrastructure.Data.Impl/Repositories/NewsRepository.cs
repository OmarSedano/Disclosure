using System;
using System.Collections.Generic;
using System.Linq;
using Disclosure.Domain;
using Disclosure.Infrastructure.Data.Contracts;

namespace Disclosure.Infrastructure.Data.Impl.Repositories
{


    public class NewsRepository : INewsRepository
    {
        public void Insert(NewsEntity newsEntity)
        {
            using (var dbCtx = new DisclosureDbContext())
            {
                dbCtx.Entry(newsEntity).State = System.Data.Entity.EntityState.Added;
                dbCtx.SaveChanges();
            }
        }

        public void Update(NewsEntity newsEntity)
        {
            using (var dbCtx = new DisclosureDbContext())
            {
                dbCtx.Entry(newsEntity).State = System.Data.Entity.EntityState.Modified;
                dbCtx.SaveChanges();
            }
        }


        public void Delete(int id)
        {
            using (var dbCtx = new DisclosureDbContext())
            {
                var entity = dbCtx.News.Find(id);
                if (entity == null) 
                    throw new Exception(String.Format("Entity with given id:{0} not found", id));

                dbCtx.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                dbCtx.SaveChanges();
            }
        }

        public NewsEntity Get(int id)
        {
            using (var dbCtx = new DisclosureDbContext())
            {
                var newsEntity = dbCtx.News.Find(id);
                return newsEntity;
            }
        }

        public List<NewsEntity> Get()
        {
            using (var dbCtx = new DisclosureDbContext())
            {
                var newsEntities = dbCtx.News.ToList();
                return newsEntities;
            }
        }
    }
}
