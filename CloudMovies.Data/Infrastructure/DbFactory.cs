using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudMovies.Infrastructure
{
    public class DbFactory:Disposable,IDbFactory
    {
        CloudMoviesContext dbContext;
        public CloudMoviesContext Init()
        {
            return dbContext ?? (dbContext = new CloudMoviesContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext!=null)
            {
                dbContext.Dispose();
            }
        }
    }
}
