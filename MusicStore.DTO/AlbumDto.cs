using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.DTO
{
    public class AlbumDto
    {
        public IEnumerable<TrackDto> Tracks { get; set; }
        public string Name { get; set; }
        public ArtistDto Artist { get; set; }
        public decimal Price { get; set; }
    }
}
