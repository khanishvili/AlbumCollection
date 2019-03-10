using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Models
{
    public class Song
    {
        [Required]
        public int SongId { get; set; }
        [Required]
        public string Song_Name { get; set; }
        
        public virtual int AlbumId { get; set; }
       
    }
}
