using System.Collections.Generic;

namespace MusicStore.DTO
{
    public class AlbumDto
    {
        public int Id { get; set; }

        public IEnumerable<TrackDto> Tracks { get; set; }
        
        public string Name { get; set; }
        
        public ArtistDto Artist { get; set; }
        
        public int ArtistId { get; set; }
        
        public decimal Price { get; set; }
    }
}
