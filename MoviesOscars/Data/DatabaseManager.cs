using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesOscars.Data
{
    public class DatabaseManager : IDataStorage
    {
        public string DatabaseName { get; set; }

        //public OleDbConnection connection { get; set; }

        public DatabaseManager() { }

        private int GetPrimaryKeyMovie(int a)
        {
            return 0;
        }
        private int GetPrimaryKeyOscar(int a)
        {
            return 0;
        }

        public void CreateStorageMedium(string a, string b)
        {
            throw new NotImplementedException();
        }

        public int GetAmountOfSavedObjects(string a, string b)
        {
            throw new NotImplementedException();
        }

        public void SaveNewAmount(string a, string b, int c)
        {
            throw new NotImplementedException();
        }

        public void GetMovie(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveMovie(Movie movie, int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        public void GetOscar(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveOscar(Oscar oscar, int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteOscar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
