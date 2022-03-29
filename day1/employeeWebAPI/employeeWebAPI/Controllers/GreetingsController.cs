using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace employeeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {

        [HttpGet]
        [Route("greet")]
        public IActionResult GreetUser()
        {            
            //method will return HTTPStatus Code
            return Ok("Hello and Welcome to WebAPI");
        }


        [HttpGet]
        [Route("friends")]
        public IActionResult FriendsList()
        {
            List<string> friends = new List<string>();
            friends.Add("Pooja");
            friends.Add("Akshay");
            friends.Add("Amar");
            friends.Add("Akbar");
            friends.Add("Anthony");
            friends.Add("Ramesh");
            friends.Add("Suresh");
            friends.Add("Rohan");

            return Ok(friends);
        }
    }
}
