using Microsoft.AspNetCore.Mvc;

namespace Esperanza.API.Controllers
{
    [ApiController]
    [Route("/api")]
    public class StudentsController: ControllerBase
    {
        [HttpGet]
        public string HelloWorld()
        {
            return "hola mundo";
        }

    }
}
