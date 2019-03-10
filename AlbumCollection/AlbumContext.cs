using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using AlbumCollection.Models;

namespace AlbumCollection
{
    public class AlbumContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=DVTsAlbums;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData
                (
                new Album()
                {
                    AlbumId = 1,
                    Artist_Name= "Avenged Sevenfold ",
                    Name="Hail To The King"                   
                },
                new Album()
                   {
                       AlbumId = 2,
                       Artist_Name = "Avenged Sevenfold ",
                       Name = "Nightmare "
                   },
                new Album()
                   {
                       AlbumId = 3,
                       Artist_Name = "Avenged Sevenfold ",
                       Name = "The Stage "
                   }
                );
            modelBuilder.Entity<Song>().HasData
                (
               new Song()
               {
                   SongId = 1,
                   Song_Name = "Hail to The King",
                   AlbumId=1
                   
               },
               new Song()
                {
                    SongId = 2,
                    Song_Name = "Shepherd Of Fire",
                    AlbumId = 1
                },
               new Song()
                {
                    SongId = 3,
                    Song_Name = "Shepherd Of Fire",
                    AlbumId = 1
                },
               new Song()
                  {
                      SongId = 4,
                      Song_Name = "Doing Time",
                      AlbumId = 1
               },
               new Song()
               {
                   SongId = 5,
                   Song_Name = "Wellcome To The Family",
                   AlbumId = 2
               },
               new Song()
               {
                   SongId =6,
                   Song_Name = "Danger Line",
                   AlbumId = 2
               },
               new Song()
               {
                   SongId = 7,
                   Song_Name = "Victim",
                   AlbumId = 2
               },
               new Song()
               {
                   SongId = 8,
                   Song_Name = "Paradigm",
                   AlbumId = 3
               },
               new Song()
                {
                    SongId = 9,
                    Song_Name = "The Stage",
                    AlbumId = 3
                },
               new Song()
                 {
                     SongId = 10,
                     Song_Name = "Angels",
                     AlbumId = 3
                 }
               );
               
            base.OnModelCreating(modelBuilder);
        }
    }
}
