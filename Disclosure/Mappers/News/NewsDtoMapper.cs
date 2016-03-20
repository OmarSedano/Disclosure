using Disclosure.Application.Contracts.Dtos.NewsService;
using Disclosure.Models.News;

namespace Disclosure.Mappers.News
{
    public static class NewsDtoMapper
    {
        public static NewsDto Map(NewsModel newsModel)
        {
            return new NewsDto
            {
                Id = newsModel.Id,
                Author = newsModel.Author,
                Body = newsModel.Body,
                Headline = newsModel.Headline,
                Summary = newsModel.Summary
            };
        }
    }
}