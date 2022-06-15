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

    public class CursosController : ControllerBase
    {
        private GestaoServices _cursos =
           new GestaoServices();

        [HttpPost]
        public ActionResult CadastrarCursos(
            [FromBody] CursosViewModel cursosRecebido)
        {
            if (cursosRecebido == null)
            {
                return BadRequest("Não foi recebido nenhum informação de cursos.");
            }

            Cursos objetoCriado = _cursos
                .CadastrarCursos(cursosRecebido);

            return Created("Cursos", objetoCriado);
        }
        [HttpGet]
        public List<Cursos> ListarCursos()
        {
            List<Cursos> listaCursos =
                _cursos.ListarCursos();

            return listaCursos;
        }
        //[HttpPut]
        //public Cursos PutCursos(int cursos_id, [FromBody] CursosViewModel cursosupdate)
        //{
        //     cursosupdate.cursos_id = cursos_id;
        //     return cursosupdate();
        //}
       
        //[HttpDelete("{id}")]
        //public ActionResult DeletarCurso(int cursos_id)[FromBody] CursosViewModel cursosRemove)
        //{
        //    Cursos objetoRemove = _cursos
        //        .DeletarCurso(cursosRemove);
        //    return Remove("Cursos", objetoRemove);
        //}
    }
}
