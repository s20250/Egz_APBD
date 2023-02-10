using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzamin_APBD_s20250.Models
{
    public class MusicLabel
    {
        public MusicLabel()
        {
            Albums = new HashSet<Album>();
        }

        public virtual ICollection<Album> Albums { get; set; }

        public int IdMusicLabel { get; set; }
        public string Name { get; set; }
    }
}