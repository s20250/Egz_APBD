namespace Egzamin_APBD_s20250.Models;

public class MusicianTrack
{
    
    public int IdTrack { get; set; }
    public int IdMusician { get; set; }
    
    public virtual Musician IdMusicianNav { get; set; }
    public virtual Track IdTrackNav { get; set; }
}