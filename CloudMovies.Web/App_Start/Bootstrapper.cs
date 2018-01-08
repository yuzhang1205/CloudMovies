using CloudMovies.Web.Infrastructure.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CloudMovies.Web.App_Start
{
    public class Bootstrapper
    {
        public static void Run()
        {
            AutofacWebapiConfig.Initiaze(GlobalConfiguration.Configuration);
            AutoMapperConfiguration.Configure();
        }
    }
}