using Egzamin_APBD_s20250.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egzamin_APBD_s20250.Configurations;

public class MusicianConfig  : IEntityTypeConfiguration<Musician>
{
    public void Configure(EntityTypeBuilder<Musician> builder)
    {
        builder.HasKey(e => e.IdMusician).HasName("Musician_PK");
        builder.Property(e => e.IdMusician).UseIdentityColumn();

        builder.Property(e => e.FirstName).HasMaxLength(30).IsRequired();
        builder.Property(e => e.LastName).HasMaxLength(50).IsRequired();
        builder.Property(e => e.nickname).HasMaxLength(20).IsRequired();


        // adding data
        var musicians = new List<Musician>();

        musicians.Add(new Musician()
        {
            IdMusician = 1,
            FirstName = "Jan",
            LastName = "Kowalski",
            nickname = "Janko Muzykant"
        });

        musicians.Add(new Musician()
        {
            IdMusician = 2,
            FirstName = "Janka",
            LastName = "Kowalska",
            nickname = "Janka Muzykantka"
        });

        builder.HasData(musicians);
    }

}