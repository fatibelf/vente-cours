using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace course_website.Models
{
    public class course
    {
        [Key]
        public int id { get; set; }
        public string titre { get; set; }
        public string description { get; set; }
        public double prix { get; set; }
        public string imageurl { get; set; }
        public DateTime datedibut { get; set; }
        public DateTime datefin { get; set; }

    }
}
