using System;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.DAL.Models
{
    public class Track : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required]
        public virtual Album Album { get; set; }
        public int AlbumId { get; set; }

        [Required]
        public virtual Genre Genre { get; set; }
        public int GenreId { get; set; }

        [Required]
        public float Duration { get; set; }
    }
}