using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _5StarWifi.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public int Rating { get; set; }
        public string SrcPath { get; set; }
        public int ViewCount { get; set; }
        public string Genre { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
    }
}