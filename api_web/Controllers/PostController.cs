using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace api_web.Controllers
{
    [ApiController]
    [Route("/post")]
    public class PostController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        
        private List<Post> posts = new List<Post>()
        {
            new Post()
            {
                id = 1,
                title ="KonflikNatuna",
                content = "Ini bahaya bosqu",
                tags="beritahot",
                status="approved",
                create_time = "09Januari2020",
                update_time = "10Januari2020",
                author_id = 80001
            },

            new Post()
            {
                id = 2,
                title ="KonflikReynhard",
                content = "Ini bahaya beut bosqu",
                tags="beritapanas",
                status="not approved",
                create_time = "10Januari2020",
                update_time = "11Januari2020",
                author_id = 80001

            }
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

        private readonly ILogger<UserController> _logger;

        public PostController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Post> GetAllPosts()
        {
            return posts;
        }
        

        [HttpGet("{id}")]
        public Post GetPosts (int id)
        {
            return posts[id-1];
        }

        [HttpPost]
        public Post AddPost(Post post)
        {
            return post;
        }

        [HttpPut ("{id}")]
        public Post EditPost(int id, Post post)
        {
            return post;
        }

        [HttpDelete ("{id}")]
        public string DeletePost (int id)
        {
            return "Post has been deleted";
        }

        [HttpGet ("{id}/comment")]
        public List<Comment> GetAllComments()
        {
            return comments;
        }
        

        [HttpGet("{id}/comment/{idcomment}")]
        public Comment GetComment (int id, int idcomment)
        {
            return comments[idcomment-1];           
        }

        [HttpPost("{id}/comment")]
        public Comment AddCommnet(Comment comment)
        {
            return comment;
        }

        [HttpPut ("{id}/comment/{idcomment}")]
        public Comment EditComment(int id, int idcomment, Comment comment)
        {
            return comment;
        }

        [HttpDelete ("{id}/comment/{idcomment}")]
        public string DeleteComment (int id, int idcomment)
        {
            return "Comment has been deleted";
        }


    }
}
