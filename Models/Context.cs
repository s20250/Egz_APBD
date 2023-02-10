using System.Data.Common;
using Egzamin_APBD_s20250.Configurations;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.EntityFrameworkCore;


namespace Egzamin_APBD_s20250.Models;
public class Context : DbContext
    {
        public Context() { }
        
        public Context(DbContextOptions<Context> options) : base(options) { }

        public virtual DbSet<MusicLabel> MusicLabel { get; set; }
        public virtual DbSet<Album> Album { get; set; }   
        public virtual DbSet<Track> Track { get; set; }
        public virtual DbSet<MusicianTrack> MusicianTrack { get; set; }
        public virtual DbSet<Musician> Musician { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MusicLabelConfig());
            modelBuilder.ApplyConfiguration(new AlbumConfig());
            modelBuilder.ApplyConfiguration(new TrackConfig());
            modelBuilder.ApplyConfiguration(new MusicianTrackConfig());
            modelBuilder.ApplyConfiguration(new MusicianConfig());

        }
        
    }
