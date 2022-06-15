using CursoProfessor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProfessor.Respository
{
    public class Application : DbContext
    {
    public DbSet<Cursos> TabelaDeCursos { get; set; }

    public DbSet<Professores> TabelaDeProfessores { get; set; }

    protected override void OnConfiguring(
        DbContextOptionsBuilder construtor)
       {
            string conexao = "Server=localhost\\SQLEXPRESS;" + 
                "Database=CursoProfessor;Integrated Security=SSPI";
            construtor.UseSqlServer(conexao);
       }

    }
}
