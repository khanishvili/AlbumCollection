using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Models;

namespace AlbumCollection.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        AlbumContext db;
        public AlbumRepository(AlbumContext db)
        {
            this.db = db;
        }
        public IEnumerable<Album> GetAll()
        {
            return db.Albums.ToList();
        }
    }
}
