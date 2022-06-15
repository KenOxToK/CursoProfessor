using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CursoProfessor.Models
{
    public class Cursos 
    {
        [Key]
        public int cursos_id { get; set; }
        public string cursos_nome { get; set; }
        public int cursos_sala { get; set; }
    }
}
