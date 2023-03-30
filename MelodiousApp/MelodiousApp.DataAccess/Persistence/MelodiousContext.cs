using MelodiousApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph;

namespace MelodiousApp.DataAccess.Persistence
{
    public class MelodiousContext : DbContext
    {
        public MelodiousContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<ArtistSong> ArtistSongs { get; set; }
        public DbSet<Credential> Credentials { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<PlayListSong> PlayListSongs { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<SongAlbum> SongAlbums { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPlayList> UserPlayLists { get; set; }
    }
}