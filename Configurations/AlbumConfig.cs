using System;
using System.Collections.Generic;
using Egzamin_APBD_s20250.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egzamin_APBD_s20250.Configurations
{
    public class AlbumConfig : IEntityTypeConfiguration<Album>
    { public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(e => e.IdAlbum).HasName("TaskType_PK");
            builder.Property(e => e.IdAlbum).UseIdentityColumn();

            builder.Property(e => e.AlbumName).HasMaxLength(30).IsRequired();
            builder.Property(e => e.PublishDate).IsRequired();

            builder.HasOne(e => e.IdMusicLabel)
                .WithMany(e => e.Album)
                .HasForeignKey(e => e.IdMusicLabel)
                .OnDelete(DeleteBehavior.ClientSetNull);
            // .HasContrainName("IDTeam_FK");

            // adding data
            var album = new List<Album>();

            album.Add(new Album()
            {
                IdAlbum = 1,
                AlbumName = "Album01",
                PublishDate = new DateTime(2022,01,01),
                
                
            });

            album.Add(new Album()
            {
                IdMusicLabel = 2,
                AlbumName = "Album01",
                PublishDate = new DateTime(2002,01,01),
                
            });
                
            builder.HasData(album);
        }


      
    }
}