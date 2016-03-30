using System;
using System.Collections.Generic;
using System.Linq;
using Disclosure.Application.Contracts.Dtos.NewsService;
using Disclosure.Application.Contracts.ServiceContracts;
using Disclosure.Application.Impl.Mappers.NewsService;
using Disclosure.Infrastructure.Data.Contracts;

namespace Disclosure.Application.Impl.Services
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _newsRepository;

        public NewsService(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public void AddNews(NewsDto newsDto)
        {
            newsDto.PublicationDate = DateTime.UtcNow;
            _newsRepository.Insert(NewsEntityMapper.MapToAdd(newsDto));
        }

        public void UpdateNews(NewsDto newsDto)
        {
            _newsRepository.Update(NewsEntityMapper.MapToUpdate(newsDto));
        }

        public void DeleteNews(int id)
        {
            _newsRepository.Delete(id);
        }

        public NewsDto GetNews(int id)
        {
            var newsEntity= _newsRepository.Get(id);
            var newsDto = NewsDtoMapper.Map(newsEntity);
            return newsDto;
        }

        public List<NewsDto> GetAllNews()
        {
            var newsEntities = _newsRepository.Get();
            var newsDtos = newsEntities.Select(NewsDtoMapper.Map).ToList();
            return newsDtos;
        }
    }
}
