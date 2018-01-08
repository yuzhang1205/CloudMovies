using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudMovies.Entities;

namespace CloudMovies.Configurations
{
    public class RentalConfiguration:EntityBaseConfiguration<Rental>
    {
        public RentalConfiguration()
        {
            Property(r => r.CustomeId).IsRequired();
            Property(r => r.StockId).IsRequired();
            Property(r => r.RentalDate).IsRequired();
            Property(r => r.ReturnedDate).IsRequired();
            Property(r => r.Status).IsRequired().HasMaxLength(10);
        }
    }
}
