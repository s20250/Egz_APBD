
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Egzamin_APBD_s20250.Models.DTO;

namespace Egzamin_APBD_s20250.Services;

public interface IAlbumDb
{
        Task<AlbumDto> GetAlbum(int it);
        Task<string> DeleteMusician(int id);
   
    }
