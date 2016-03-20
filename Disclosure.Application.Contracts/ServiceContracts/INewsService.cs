using System.Collections.Generic;
using Disclosure.Application.Contracts.Dtos.NewsService;

namespace Disclosure.Application.Contracts.ServiceContracts
{
    public interface INewsService
    {
        void AddNews(NewsDto newsDto);
        void UpdateNews(NewsDto newsDto);
        void DeleteNews(int id);
        NewsDto GetNews(int id);
        List<NewsDto> GetAllNews();
    }
}