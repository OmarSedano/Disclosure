using System;
using Disclosure.Application.Contracts.Dtos.NewsService;
using Disclosure.Domain;

namespace Disclosure.Application.Impl.Mappers.NewsService
{
    public static class NewsDtoMapper
    {
        public static NewsDto Map(NewsEntity newsEntity)
        {
            return new NewsDto
            {
                Id = newsEntity.Id,
                Author = newsEntity.Author,
                Body = newsEntity.Body,
                Headline = newsEntity.Headline,
                PublicationDate = newsEntity.PublicationDate.HasValue ? newsEntity.PublicationDate.Value : new DateTime(1999, 12, 31),
                Summary = newsEntity.Summary
            };
        }
    }
}
