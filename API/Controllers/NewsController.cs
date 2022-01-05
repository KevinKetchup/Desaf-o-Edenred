using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Controllers.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/getNews")] 
    public class NewsController : ControllerBase
    {
        public NewsController(){}

        [HttpGet (Name = "GetNewsSearch")]
        public async Task<NewsList> GetNews(string keyword,string fromDate, string toDate)
        {
            return await NewsAPI.searchNews(keyword, fromDate, toDate);
        }
    }
    [Route("api/getTopHeadlines")] 
    public class NewsController2 : ControllerBase
    {
        public NewsController2(){}
                
        [HttpGet (Name = "GetNewsTopHeadlines")]
        public async Task<NewsList> topHeadLines(string country)
        {
            return await NewsAPI.topHeadLines(country);
        }
    }
}