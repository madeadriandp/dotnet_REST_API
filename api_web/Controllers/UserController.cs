using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace api_web.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private List<User> users = new List<User>()
            {
                new User()
                {
                id = 80001,
                email = "susilo@gmail.com",
                profile = "ExPresident",
                salt = "ckuaaaaks",
                username = "Susilo",
                password =  "bambang123"
                },

                new User()
                {
                id = 80002,
                email = "wati@gmail.com",
                profile = "ExPresident",
                salt = "klakklikkluk",
                username = "Mega",
                password =  "mega456"
                }
            };

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<User> GetAllUser()
        {
            return users;
        }
        

        [HttpGet("{id}")]
        public User GetUser (int id)
        {
            return users[id-1];         
        }

        [HttpPost]
        public User AddUser(User user)
        {
            return user;
        }

        [HttpPut ("{id}")]
        public User EditUser(int id, User user)
        {
            return user;
        }

        [HttpDelete ("{id}")]
        // public string DeleteUser (int id)
        public List<User> DeleteUser(int id)
        {   
            users.RemoveAt(id-1);
            return users;
            // return "User has been deleted";
        }


    }
}
