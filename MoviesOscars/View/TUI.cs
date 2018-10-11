using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesOscars.FunctionalSpecification;

namespace MoviesOscars.View
{
    public class TUI
    {
        private IFunctionalConcept FunctionalConcept;

        public TUI()
        {
            FunctionalConcept = new FunctionalConcept();

            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
