using CursoProfessor.Models;
using CursoProfessor.Respository;
using CursoProfessor.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursoProfessor.Services
{
    public class GestaoServices
    {
        private Application _context = new Application();

        //private List<Cursos> _cursos = Armazenamento.Cursos;
        //private List<Professores> _professores = Armazenamento.Professores;
        
        public Cursos CadastrarCursos(CursosViewModel cursosrecebidos)
        {
            Cursos cursos = new Cursos();
            cursos.cursos_id = cursosrecebidos.cursos_id;
            cursos.cursos_nome = cursosrecebidos.cursos_nome;
            cursos.cursos_sala = cursosrecebidos.cursos_sala;

            _context.TabelaDeCursos.Add(cursos);
            _context.SaveChanges();

            return cursos;
        }

        public List<Cursos> ListarCursos()
        {
            return _context.TabelaDeCursos
                .OrderBy(cursos => cursos.cursos_id)
                .OrderBy(cursos => cursos.cursos_nome)
                .ThenBy(cursos => cursos.cursos_sala)
                .ToList();
        }

        public Cursos PutCursos(CursosViewModel cursosUpdate)
        {
            Cursos cursos = new Cursos();
            cursos.cursos_nome = cursosUpdate.cursos_nome;
            cursos.cursos_sala = cursosUpdate.cursos_sala;

            _context.TabelaDeCursos.Add(cursos);
            _context.SaveChanges();

            return cursos;
        }

        public void DeletarCurso(int cursos_id)
        {
            Cursos cursos = new Cursos();
            _context.TabelaDeCursos.Remove(cursos);
            _context.SaveChanges();
        }

        public void CadastrarCursos()
        {
            Cursos cursos = new Cursos();

            Console.WriteLine("Qual o seu id?");
            cursos.cursos_id = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o nome de curso?");
            cursos.cursos_nome = Console.ReadLine();

            Console.WriteLine("Qual o numero da sala?");
            cursos.cursos_sala = int.Parse(Console.ReadLine());
        }
            //////////-------------------
            //////////-------------------
            //////////-------------------
        public Professores CadastrarProfessores(ProfessoresViewModel professoresrecebidos)
        {
            Professores professores = new Professores();

            professores.professores_id = professoresrecebidos.professores_id;
            professores.professores_nome = professoresrecebidos.professores_nome;
            professores.professores_email = professoresrecebidos.professores_email;

            
            _context.TabelaDeProfessores.Add(professores);
            _context.SaveChanges();

            return professores;
        }

        public List<Professores> ListarProfessores()
        {
            return _context.TabelaDeProfessores
               .OrderBy(professores => professores.professores_id)
                .OrderBy(professores => professores.professores_nome)
                .OrderBy(professores => professores.professores_email)
                .ToList();
        }
        public Professores PutProfessores(ProfessoresViewModel professoresupdate)
        {
            Professores professores = new Professores();
            professores.professores_nome = professoresupdate.professores_nome;
            professores.professores_email = professoresupdate.professores_email;
            _context.TabelaDeProfessores.Add(professores);
            _context.SaveChanges();

            return professores;
        }
        public void DeletarProfessores(int professores_id)
        {
            Professores professores = new Professores();

            _context.TabelaDeProfessores.Remove(professores);
            _context.SaveChanges();

        }
        public void CadastrarProfessores()
        {
            Professores professores = new Professores();

            Console.WriteLine("Qual o seu id?");
            professores.professores_id = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o nome de curso?");
            professores.professores_nome = Console.ReadLine();

            Console.WriteLine("Qual o numero da sala?");
            professores.professores_email = Console.ReadLine();

            _context.TabelaDeProfessores.Add(professores);
            _context.SaveChanges();
        }
        public List<object> ListarDisciplina()
        {
            List<object> listaQueVaiSerRetornada = new List<object>();

            listaQueVaiSerRetornada.AddRange(_context.TabelaDeCursos);
            listaQueVaiSerRetornada.AddRange(_context.TabelaDeProfessores);

            return listaQueVaiSerRetornada;
        }
    }
}
