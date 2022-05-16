using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace course_website.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
    }
}
