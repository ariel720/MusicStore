using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicStore.Models;

namespace MusicStore.Models
{
    public class MusicStoreContext : DbContext
    {
        public MusicStoreContext (DbContextOptions<MusicStoreContext> options)
            : base(options)
        {
        }

        public DbSet<MusicStore.Models.Genre> Genre { get; set; }

        public DbSet<MusicStore.Models.Album> Album { get; set; }

        public DbSet<MusicStore.Models.Song> Song { get; set; }
    }
}
