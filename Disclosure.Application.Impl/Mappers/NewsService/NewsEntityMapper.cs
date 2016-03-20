using Disclosure.Application.Contracts.Dtos.NewsService;
using Disclosure.Domain;

namespace Disclosure.Application.Impl.Mappers.NewsService
{
    public static class NewsEntityMapper
    {
        public static NewsEntity Map(NewsDto newsDto)
        {
            return new NewsEntity
            {
                Id = newsDto.Id,
                Author = newsDto.Author,
                Body = newsDto.Body,
                Headline = newsDto.Headline,
                PublicationDate = newsDto.PublicationDate,
                Summary = newsDto.Summary
            };
        }
    }
}
