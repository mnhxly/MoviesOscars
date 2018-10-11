using MoviesOscars.FunctionalSpecification;
using System;
using System.Collections.Generic;
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
        }
    }
}
