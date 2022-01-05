using System.Collections;
using System.Collections.Generic;

namespace API.Controllers.Entities

{
    public class NewsList{
        public string status {get; set;}
        public int totalResults {get; set;}
        public List<News> articles {get; set;}
    }

    public class NewsSource{
        public string id {get; set; }
        public string name {get; set;}
    }
    public class News
    {   
        public NewsSource source {get; set;}
        public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string urlToImage { get; set; }
        public string publishedAt { get; set; }
        public string content { get; set; }

    }
}