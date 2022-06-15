using Microsoft.AspNetCore.Mvc;

namespace CursoProfessor.API.Controllers
{
    [ApiController]
    [Route("cursoprofessor")]
    public class CursoProfessor : Controller
    {
        [HttpGet]
        public string Inicio()
        {
            return "Bem vendo no area de aluno";
        }
    }
}
