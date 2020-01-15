using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace api_web.Controllers
{
    [ApiController]
    [Route("post/comment")]
    public class CommentController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        
        private List<Comment> comments = new List<Comment>()
        {
            new Comment()
            {
                id = 1,
                content = "Kebanyakan komen awas hoax",
                status="aman untuk dibaca",
                create_time = "09Januari2020",
                author ="abunawas",
                email="abunawas@gmail.com",
                url = "abu_nawas.abu.co.id",
                post_id = "F16"
            },

           new Comment()
            {
                id = 2,
                content = "Kebanyakan komen awas fakta",
                status="tida aman untuk dibaca",
                create_time = "10Januari2020",
                author ="peterparker",
                email="peterparker@gmail.com",
                url = "peter_parker.abu.co.id",
                post_id = "A20"
            },
        };

        private readonly ILogger<CommentController> _logger;

        public CommentController(ILogger<CommentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Comment> GetAllComments()
        {
            return comments;
        }
        

        [HttpGet("{id}")]
        public Comment GetComment (int id)
        {
            return comments[id-1];
            // new User() {
            //     id = id,
            //     email = "susilo@gmail.com",
            //     profile = "ExPresident",
            //     salt = "ckuaaaaks",
            //     username = "Susilo", 
            //     password =  "bambang123"
            // };
        }

        [HttpPost]
        public Comment AddCommnet(Comment comment)
        {
            return comment;
        }

        [HttpPut ("{id}")]
        public Comment EditComment(int id, Comment comment)
        {
            return comment;
        }

        [HttpDelete ("{id}")]
        public string DeleteComment (int id)
        {
            return "Comment has been deleted";
        }


    }
}
