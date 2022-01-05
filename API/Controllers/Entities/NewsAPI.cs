using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace API.Controllers.Entities
{
    public class NewsAPI    
    {
        public static async Task<NewsList> searchNews(string keyword, string fromDate, string toDate)
        {
            var url = $"https://newsapi.org/v2/everything?q={keyword}&from={fromDate}&to={toDate}&language=es&apiKey=b9ba7849d7dd4bc8974ef37f481dd7cd";
            using (var HttpClient = new HttpClient())
            {
                var respuesta = await HttpClient.GetAsync(url);
                HttpClient.DefaultRequestHeaders.Accept.Clear();

                if (respuesta.IsSuccessStatusCode)
                {
                    var respuestaString = await respuesta.Content.ReadAsStringAsync();
                    var listadoNews = JsonConvert.DeserializeObject<NewsList>(respuestaString);
                    return listadoNews;
                }
                else
                {
                    return new NewsList()
                    {
                        status = "error",
                        totalResults = 0,
                        articles = null
                    };
                }

            }
        }

        public static async Task<NewsList> topHeadLines(string country)
        {
            var url = $"https://newsapi.org/v2/top-headlines?country={country}&apiKey=b9ba7849d7dd4bc8974ef37f481dd7cd";
            using (var HttpClient = new HttpClient())
            {
            
                var respuesta = await HttpClient.GetAsync(url);
                HttpClient.DefaultRequestHeaders.Accept.Clear();

                if (respuesta.IsSuccessStatusCode)
                {
                    var respuestaString = await respuesta.Content.ReadAsStringAsync();
                    var listadoNews = JsonConvert.DeserializeObject<NewsList>(respuestaString);
                    return listadoNews;
                }
                else
                {
                    return new NewsList()
                    {
                        status = "error",
                        totalResults = 0,
                        articles = null
                    };
                }

            
            }
        }
    }
}