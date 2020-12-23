using Microsoft.EntityFrameworkCore;
using System;
using WindowsFromsApp1.Database.Entities;

namespace ProiectDeAn.Database
{
     public class DatabaseContext : DbContext
     {
          private const string connectionString = @"data source=WIN-ERR416QKVC4; Initial Catalog=GreenHouseDB; Trusted_Connection=True; ";
          private static DatabaseContext _databaseContext;

          private DatabaseContext() { }
          private DatabaseContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
          {

          }

          public static DatabaseContext GetInstance()
          {
               
               if (_databaseContext == null)
               {
                    _databaseContext = new DatabaseContext();
               }
               return _databaseContext;
          }
          
          public DbSet<DataHistory> DataHistories { get; set; }
          public DbSet<Strategy> Strategies { get; set; }
          public DbSet<Zone> Zones { get; set; }

          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
               optionsBuilder.UseSqlServer(connectionString);
          }
     }
}
