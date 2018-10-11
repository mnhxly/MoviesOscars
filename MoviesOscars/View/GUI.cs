using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesOscars.View
{
    public class GUI
    {
        private FunctionalSpecification.IFunctionalConcept FunctionalConcept;

        public GUI(FunctionalSpecification.IFunctionalConcept concept) {
            this.FunctionalConcept = concept;
        }
    }
}
