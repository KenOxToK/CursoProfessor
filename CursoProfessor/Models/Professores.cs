using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CursoProfessor.Models
{
    public class Professores 
    {
        [Key]
        public int professores_id { get; set; }
        public string professores_nome { get; set; }
        public string professores_email { get; set; }
    }
}
