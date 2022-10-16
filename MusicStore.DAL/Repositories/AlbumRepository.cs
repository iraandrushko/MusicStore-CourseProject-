using Microsoft.EntityFrameworkCore;
using MusicStore.DAL.Models;
using MusicStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicStore.DAL.Repositories
{
    public class AlbumRepository : BaseRepository<Album, AlbumDto>
    {
        public void DeleteAlbum(int albumId)
        {
            var album = Database.Albums.Include(a => a.Tracks).FirstOrDefault(a => a.Id == albumId);
            foreach (var track in album.Tracks)
            {
                Database.Tracks.Remove(track);
            }
            Database.Albums.Remove(album);
            Database.SaveChanges();
         
        }
    }
}
