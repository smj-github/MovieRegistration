using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50,MinimumLength =1)]
        public string Title { get; set; }
        public string Genre { get; set; }        
        public int Year { get; set; }
        public List<string> Actors { get; set; }
        public List<string> Directors { get; set; }
    }
}
