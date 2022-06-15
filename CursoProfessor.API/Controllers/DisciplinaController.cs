using CursoProfessor.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CursoProfessor.API.Controllers
{
    [ApiController]
    [Route("disciplina")]
    public class DisciplinaController : ControllerBase
    {
        private GestaoServices _servico = new GestaoServices();

        [HttpGet]
        public IActionResult ObterDisciplina()
        {
            List<object> disciplina = _servico.ListarDisciplina();

            return Ok(disciplina);
        }
    }
}
