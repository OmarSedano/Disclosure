using System.Collections.Generic;
using Disclosure.Domain;

namespace Disclosure.Infrastructure.Data.Contracts
{
    public interface INewsRepository
    {
        void Insert(NewsEntity newsEntity);
        void Update(NewsEntity newsEntity);
        void Delete(int id);
        NewsEntity Get(int id);
        List<NewsEntity> Get();
    }
}