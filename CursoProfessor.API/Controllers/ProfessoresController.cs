using CursoProfessor.Models;
using CursoProfessor.Services;
using CursoProfessor.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CursoProfessor.API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProfessoresController : ControllerBase
    {
        private GestaoServices _professores =
            new GestaoServices();

        [HttpPost]
        public ActionResult CadastrarSerie(
            [FromBody] ProfessoresViewModel professoresRecebido)
        {
            if (professoresRecebido == null)
            {
                return BadRequest("Não foi recebido nenhum informação de professores.");
            }

            Professores objetoCriado = _professores
                .CadastrarProfessores(professoresRecebido);

            return Created("Professores", objetoCriado);
        }
        [HttpGet]
        public List<Professores> ListarProfessores()
        {
            List<Professores> listaProfessores =
                _professores.ListarProfessores();

            return listaProfessores;
        }
    }
}
