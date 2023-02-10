namespace Egzamin_APBD_s20250.Models;

public class Musician
{
    public Musician()
        {
            MusicianTracks = new HashSet<MusicianTrack>();
        }

        public virtual ICollection<MusicianTrack> MusicianTracks { get; set; }

        public int IdMusician { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string nickname { get; set; }
        

}