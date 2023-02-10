using Egzamin_APBD_s20250.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egzamin_APBD_s20250.Configurations;

public class MusicianTrackConfig : IEntityTypeConfiguration<MusicianTrack>
{
    public void Configure(EntityTypeBuilder<MusicianTrack> builder)
    {
        builder.HasKey(e => new
        {
           e.IdTrack,
           e.IdMusician
        }).HasName("MusicianTrack_Id");

        builder.ToTable("MusicianTrack");

        builder.HasOne(e => e.IdTrackNav)
            .WithMany(e => e.Musiciantrack)
            .HasForeignKey(e => e.IdTrack)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Medicament_Prescription_FK");

        builder.HasOne(e => e.IdMusicianNav)
            .WithMany(e => e.Musiciantrack)
            .HasForeignKey(e => e.IdMusician)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Prescription_Medicament_FK");

        // adding data

        var list = new List<MusicianTrack>();

        list.Add(new MusicianTrack()
        {
         IdMusician = 1,
         IdTrack = 1
        });

        list.Add(new MusicianTrack()
        {
            IdMusician = 2,
            IdTrack = 2
        });

        list.Add(new PrescriptionMedicament
        {
            IdMedicament = 2,
            IdPrescription = 2,
            Dose = 100,
            Details = "2 pigułki, rano i na wieczór"
        });

        builder.HasData(list);
    }
}
}