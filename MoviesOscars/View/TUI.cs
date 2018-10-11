using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesOscars.View
{
    public class TUI
    {
        private FunctionalSpecification.IFunctionalConcept FunctionalConcept;

        public TUI(FunctionalSpecification.IFunctionalConcept concept)
        {
            this.FunctionalConcept = concept;
        }
    }
}
