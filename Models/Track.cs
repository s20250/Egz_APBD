
namespace Egzamin_APBD_s20250.Models;

public class Track
{
    
    public Track()
    {
        MusicianTracks = new HashSet<MusicianTrack>();
    }

    public virtual ICollection<MusicianTrack> MusicianTracks { get; set; }


    public int IdTrack { get; set; }
    public string TrackName { get; set; }
    public float Duration { get; set; } 
    public int IdAlbum { get; set; }
    
    public virtual Album IdAlbumNav { get; set; }

}