using Disclosure.Application.Contracts.Dtos.NewsService;
using Disclosure.Models.News;

namespace Disclosure.Mappers.News
{
    public static class NewsModelMapper
    {
        public static NewsModel Map(NewsDto newsDto)
        {
            return new NewsModel
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