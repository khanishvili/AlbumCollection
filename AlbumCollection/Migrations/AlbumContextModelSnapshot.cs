﻿// <auto-generated />
using AlbumCollection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlbumCollection.Migrations
{
    [DbContext(typeof(AlbumContext))]
    partial class AlbumContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlbumCollection.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Artist_Name");

                    b.Property<string>("Name");

                    b.HasKey("AlbumId");

                    b.ToTable("Albums");

                    b.HasData(
                        new { AlbumId = 1, Artist_Name = "Avenged Sevenfold ", Name = "Hail To The King" },
                        new { AlbumId = 2, Artist_Name = "Avenged Sevenfold ", Name = "Nightmare " },
                        new { AlbumId = 3, Artist_Name = "Avenged Sevenfold ", Name = "The Stage " }
                    );
                });

            modelBuilder.Entity("AlbumCollection.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId");

                    b.Property<string>("Song_Name");

                    b.HasKey("SongId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new { SongId = 1, AlbumId = 1, Song_Name = "Hail to The King" },
                        new { SongId = 2, AlbumId = 1, Song_Name = "Shepherd Of Fire" },
                        new { SongId = 3, AlbumId = 1, Song_Name = "Shepherd Of Fire" },
                        new { SongId = 4, AlbumId = 1, Song_Name = "Doing Time" },
                        new { SongId = 5, AlbumId = 2, Song_Name = "Wellcome To The Family" },
                        new { SongId = 6, AlbumId = 2, Song_Name = "Danger Line" },
                        new { SongId = 7, AlbumId = 2, Song_Name = "Victim" },
                        new { SongId = 8, AlbumId = 3, Song_Name = "Paradigm" },
                        new { SongId = 9, AlbumId = 3, Song_Name = "The Stage" },
                        new { SongId = 10, AlbumId = 3, Song_Name = "Angels" }
                    );
                });

            modelBuilder.Entity("AlbumCollection.Models.Song", b =>
                {
                    b.HasOne("AlbumCollection.Models.Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
