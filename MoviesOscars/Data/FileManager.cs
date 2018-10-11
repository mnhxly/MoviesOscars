using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesOscars.Data
{
    public class FileManager : IDataStorage
    {
        public string ProjectName { get; set; }

        public string TmpMovieDataName { get; set; }

        public string TmpOscarDataName { get; set; }

        public void CreateStorageMedium(string a, string b)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteOscar(int id)
        {
            throw new NotImplementedException();
        }

        public int GetAmountOfSavedObjects(string a, string b)
        {
            throw new NotImplementedException();
        }

        public void GetMovie(int id)
        {
            throw new NotImplementedException();
        }

        public void GetOscar(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveMovie(Movie movie, int id)
        {
            throw new NotImplementedException();
        }

        public void SaveNewAmount(string a, string b, int c)
        {
            throw new NotImplementedException();
        }

        public void SaveOscar(Oscar oscar, int id)
        {
            throw new NotImplementedException();
        }
    }
}
