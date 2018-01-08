using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudMovies.Entities;

namespace CloudMovies.Configurations
{
    public class MovieConfiguration:EntityBaseConfiguration<Movie>
    {
        public MovieConfiguration()
        {
            Property(g => g.Title).IsRequired().HasMaxLength(100);
            Property(g => g.Description).IsRequired().HasMaxLength(2000);
            Property(g => g.Image).IsOptional();
            Property(g => g.GenreId).IsRequired();
            Property(g => g.Director).IsRequired().HasMaxLength(100);
            Property(g => g.Writer).IsRequired().HasMaxLength(50);
            Property(g => g.Producer).IsRequired().HasMaxLength(50);
            Property(g => g.ReleaseDate).IsRequired();
            Property(g => g.Rating).IsRequired();
            Property(g => g.TrailerURI).HasMaxLength(200);
        }
    }
}
