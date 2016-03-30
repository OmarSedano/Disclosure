using Disclosure.Application.Contracts.Dtos.NewsService;
using Disclosure.Domain;
using System;

namespace Disclosure.Application.Impl.Mappers.NewsService
{
    public static class NewsEntityMapper
    {
        public static NewsEntity MapToAdd(NewsDto newsDto)
        {
            return new NewsEntity
            {
                Author = newsDto.Author,
                Body = newsDto.Body,
                Headline = newsDto.Headline,
                PublicationDate = DateTime.UtcNow,
                Summary = newsDto.Summary
            };
        }

        public static NewsEntity MapToUpdate(NewsDto newsDto)
        {
            return new NewsEntity
            {
                Id = newsDto.Id,
                Author = newsDto.Author,
                Body = newsDto.Body,
                Headline = newsDto.Headline,
                Summary = newsDto.Summary
            };
        }
    }  
}
