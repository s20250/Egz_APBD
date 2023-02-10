using Egzamin_APBD_s20250.Models;
using Egzamin_APBD_s20250.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Egzamin_APBD_s20250.Models;
using Egzamin_APBD_s20250.Models.DTO;
using Microsoft.EntityFrameworkCore;
using Task = System.Threading.Tasks.Task;


namespace Egzamin_APBD_s20250.Services
{
    public class AlbumDb : IAlbumDb
    {
        private readonly Context context;

        public AlbumDb(Context context)
        {
            this.context = context;
        }


        public async Task<AlbumDto> GetAlbum(int id)
        {
            var result = await context.Album.FindAsync(id);

            if (result == null)
            {
                return null;
            }

            AlbumDto albumDto = await context
                .Album
                .Where(e => e.IdAlbum == id)
                .Select(e => new AlbumDto()
                {
                    AlbumName = e.AlbumName,
                    publishDate = e.PublishDate,
                    Track = e.Tracks.Select((e => new TrackDto()
                    {
                        TrackName = e.TrackName,
                        Duration = e.Duration,
                    }))
                }).FirstAsync();

            return albumDto;
        }

     
        public async Task<string> DeleteMusician(int id)
        {

            var result = await context.Musician.FindAsync(id);

            if (result == null)
            {
                return "This musician doesn't exist";
            }
            else
            {
                var isCreating = await context.MusicianTrack.AnyAsync(e => e.IdMusician == id);

                if (isCreating)
                    return "Musician is currently working!";

                context.Remove(result);
                await context.SaveChangesAsync();

                return "Success!";
            }
        }
    }
}
    