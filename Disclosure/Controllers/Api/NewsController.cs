using System;
using System.Linq;
using System.Web.Http;
using Disclosure.Application.Contracts.ServiceContracts;
using Disclosure.Mappers.News;
using Disclosure.Models.News;

namespace Disclosure.Controllers.Api
{
    public class NewsController: ApiController
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        public IHttpActionResult GetAllNews()
        {
            var newsDtos = _newsService.GetAllNews();
            var newsModels = newsDtos.Select(NewsModelMapper.Map);
            return Ok(newsModels);
        }

        public IHttpActionResult GetNews(int id)
        {
            var newsDto = _newsService.GetNews(id);
            var newsModel = NewsModelMapper.Map(newsDto);
            return Ok(newsModel);
        }

        public IHttpActionResult Put(NewsModel newsModel)
        {
            _newsService.UpdateNews(NewsDtoMapper.Map(newsModel));
            return Ok();
        }

        public IHttpActionResult Post(NewsModel newsModel)
        {
            _newsService.AddNews(NewsDtoMapper.Map(newsModel));
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            _newsService.DeleteNews(id);
            return Ok();
        }

    }
}