using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }

        [ForeignKey("Album")]
        public int AlbumId { get; set; }

        public string Title { get; set; }

        public string ArtistName { get; set; }

        public string Featuring { get; set; }

        public int RunTime { get; set; }

    }
}
