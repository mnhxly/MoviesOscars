using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesOscars.Data
{
    interface IDataStorage
    {
        void CreateStorageMedium(string a, string b);
        int GetAmountOfSavedObjects(string a, string b);
        void SaveNewAmount(string a, string b, int c);
        void GetMovie(int id);
        void SaveMovie(Movie movie, int id);
        void DeleteMovie(int id);
        void GetOscar(int id);
        void SaveOscar(Oscar oscar, int id);
        void DeleteOscar(int id);

    }
}
