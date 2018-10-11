using Microsoft.AspNetCore.Hosting;
using MoviesOscars.FunctionalSpecification;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesOscars.View
{
    public class GUI
    {
        private IFunctionalConcept FunctionalConcept;

        public GUI()
        {
            FunctionalConcept = new FunctionalConcept();

            this.StartWebHost();
        }

        private void StartWebHost()
        {
            var host = new WebHostBuilder()
               .UseKestrel()
               .UseContentRoot(Directory.GetCurrentDirectory())
               .UseIISIntegration()
               .UseStartup<Startup>()
               .UseApplicationInsights()
               .Build();

            host.Run();
        }
    }
}
