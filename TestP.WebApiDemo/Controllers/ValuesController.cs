using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestP.WebApiDemo.Controllers
{
    public class ValuesController : Controller
    {
        [HttpGet]
        [Route("/user/{userId:int}/post/{postId}")]
        public IActionResult Getsdasda([FromRoute]int userId, [FromRoute]string postId)
        {
            var response = new object[] { userId, postId };
            return new OkObjectResult(response);
        }
    }
}
