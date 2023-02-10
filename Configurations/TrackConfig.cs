using Egzamin_APBD_s20250.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egzamin_APBD_s20250.Configurations;

public class TrackConfig: IEntityTypeConfiguration<Track>
{
    public void Configure(EntityTypeBuilder<Track> builder)
    {
        builder.HasKey(e => e.IdTrack).HasName("IdTrack_PK");
        builder.Property(e => e.IdTrack).UseIdentityColumn();

        builder.Property(e => e.TrackName).HasMaxLength(20).IsRequired();
        builder.HasIndex(e => e.TrackName).IsUnique();

        builder.Property(e => e.Duration).IsRequired();
        
        builder.HasOne(e => e.IdAlbumNav)
            .WithMany(e => e.Track)
            .HasForeignKey(e => e.IdAlbum)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("IdMusicianAlbum_FK");

        // adding data
        var track = new List<Track>();

        track.Add(new Track()
        {
           IdTrack = 1,
           TrackName = "Track01",
           Duration = 4,
        });

        track.Add(new Track()
              {
                 IdTrack = 2,
                 TrackName = "Track02",
                 Duration = 4,
              });

        
        builder.HasData(track);
    }

           
}