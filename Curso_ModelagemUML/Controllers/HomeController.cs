using Microsoft.AspNetCore.Mvc;

namespace modelagem.API.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id) 
        {
            return Ok();        
        }
        public IActionResult Insert(string asd) 
        {
            return Ok();
        }
    }
}
