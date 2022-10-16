using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.DTO
{
    public class TrackDto
    {
        public string Name { get; set; }
        public AlbumDto Album { get; set; }
        public GenreDto Genre { get; set; }
        public float Duration { get; set; }

    }
}
