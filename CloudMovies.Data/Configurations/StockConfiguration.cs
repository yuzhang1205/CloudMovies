using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudMovies.Entities;

namespace CloudMovies.Configurations
{
    public class StockConfiguration:EntityBaseConfiguration<Stock>
    {
        public StockConfiguration()
        {
            Property(s => s.MovieId).IsRequired();
            Property(s => s.UniqueKey).IsRequired();
            Property(s => s.IsAvailable).IsRequired();
        }
    }
}
