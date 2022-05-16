using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace course_website.Models
{
    public class Formateur
    {
        [Key]
        public int FormateurId { get; set; }
        public string PhotoDeProfil { get; set; }
        public string NomComplet { get; set; }
        public string Bio { get; set; }
    }
}
