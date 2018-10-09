using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesOscars
{
    public class MovieOscar
    {
        public Movie Movie { get; set; }
        public Oscar Oscar { get; set; }
        public int Year { get; set; }
    }
}
