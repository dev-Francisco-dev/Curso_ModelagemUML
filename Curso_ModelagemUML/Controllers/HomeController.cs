using Microsoft.AspNetCore.Mvc;

namespace Curso_ModelagemUML.Controllers
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



    }
}
