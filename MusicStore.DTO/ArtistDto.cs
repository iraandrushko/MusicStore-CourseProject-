using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.DTO
{
    public class ArtistDto
    {
        public IEnumerable<AlbumDto> Albums { get; set; }
        public string Name { get; set; }

    }
}
