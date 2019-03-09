using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Models;
namespace AlbumCollection.Repositories
{
   public  interface IAlbumRepository
    {
        IEnumerable<Album> GetAll();

    }
}
