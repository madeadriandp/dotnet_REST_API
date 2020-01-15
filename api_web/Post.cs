using System;
using System.Collections.Generic;
namespace api_web
{
    public class Post
    {
        public int id {get;set;}
        public string title{get;set;}
        public string content{get;set;}
        public string tags{get;set;}
        public string status{get;set;}
        public string create_time{get;set;}
        public string update_time {get; set;}
        public int author_id{get;set;}
        // public List<Comment> comments{get;set;}
                
    }
}
