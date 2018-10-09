using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesOscars.Data
{
    interface IDataStorage
    {
        void CreateStorageMedium();
        int GetAmountOfSavedObjects();
        void SaveNewAmount();
        void GetMovie();
        void SaveMovie();
        void DeleteMovie();
        void GetOscar();
        void SaveOscar();
        void DeleteOscar();

    }
}
