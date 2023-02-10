using Egzamin_APBD_s20250.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egzamin_APBD_s20250.Configurations;

public class MusicLabelConfig
    : IEntityTypeConfiguration<MusicLabel>
{
    public void Configure(EntityTypeBuilder<MusicLabel> builder)
    {
        builder.HasKey(e => e.IdMusicLabel).HasName("Musician_PK");
        builder.Property(e => e.IdMusicLabel).UseIdentityColumn();

        builder.Property(e => e.Name).HasMaxLength(50).IsRequired();

        // adding data
        var musicLabels = new List<MusicLabel>();

        musicLabels.Add(new MusicLabel()
        {
          IdMusicLabel = 1,
          Name = "Label 1"
        });

        musicLabels.Add(new MusicLabel()
        {
            IdMusicLabel = 2,
            Name = "Label 2"
        });

        builder.HasData(musicLabels);
    }

}