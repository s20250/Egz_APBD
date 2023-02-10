using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzamin_APBD_s20250.Models;

public class Album
{

    public Album()
    {
        Tracks = new HashSet<Track>();
    }

    public virtual ICollection<Track> Tracks { get; set; }
    public int IdAlbum { get; set; }
    public string AlbumName { get; set; }
    public DateTime PublishDate { get; set; }
    public int IdMusicLabel { get; set; }

   


}