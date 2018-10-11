//using System;
//using BerlinReligionClassData.Models;
//using Microsoft.EntityFrameworkCore;

//namespace MoviesOscars.Data
//{
//    public class ReligionDatabaseContext : DbContext
//    {
//        /// <summary>
//        /// Gets or sets the subventions.
//        /// </summary>
//        public DbSet<Movie> Subventions { get; set; }
//        public DbSet<Oscar> Participants { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
//            optionsBuilder.UseSqlite("Filename=./MODataBase.db");
//        }

//    }
//}
