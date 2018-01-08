using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudMovies.Web.Models
{
    public class GenreViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumberOfMovies { get; set; }
    }
}