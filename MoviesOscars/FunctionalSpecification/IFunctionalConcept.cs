using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesOscars.FunctionalSpecification
{
    interface IFunctionalConcept
    {
        string GetProjectName();
        void InitializeStorageMedium(string a);

        void ReadMovie(int id);
        void SaveNewMovie(string a);
        void ChangeMovie(int a, string b);
        void DelteMovie(int a);
        string GetMovieName();
        int GetMovieId();
        int GetMovieAmount();

        void ReadOscar(int id);
        void SaveNewOscar(string a);
        void ChangeOscar(int a, string b);
        void DelteOscar(int a);
        string GetOscarCategory();
        int GetOscarId();
        int GetOscarYear();
        int GetOscarAmount();

        void ChangeLink(int a, int b);
        int GetLinkMovieId(int a);

    }
}
