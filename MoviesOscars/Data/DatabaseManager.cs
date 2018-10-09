using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesOscars.Data
{
    public class DatabaseManager : IDataStorage
    {
        public string DatabaseName { get; set; }

        public DatabaseManager() { }


        public void CreateStorageMedium()
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie()
        {
            throw new NotImplementedException();
        }

        public void DeleteOscar()
        {
            throw new NotImplementedException();
        }

        public int GetAmountOfSavedObjects()
        {
            throw new NotImplementedException();
        }

        public void GetMovie()
        {
            throw new NotImplementedException();
        }

        public void GetOscar()
        {
            throw new NotImplementedException();
        }

        public void SaveMovie()
        {
            throw new NotImplementedException();
        }

        public void SaveNewAmount()
        {
            throw new NotImplementedException();
        }

        public void SaveOscar()
        {
            throw new NotImplementedException();
        }
    }
}
