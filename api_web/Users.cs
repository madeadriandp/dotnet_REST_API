using System;
using System.Collections.Generic;
namespace api_web
{
    public class User
    {
       public int id {get;set;}
        public string username{get;set;}
        public string password{get;set;}
        public string salt{get;set;}
        public string email{get;set;}
        public string profile{get;set;}
        // public List<Post> posts{get; set;}
                
    }
}
