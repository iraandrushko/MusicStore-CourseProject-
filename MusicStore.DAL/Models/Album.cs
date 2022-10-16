using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.DAL.Models
{
    public class Album : BaseEntity
    {
        public virtual IEnumerable<Track> Tracks { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required]
        public virtual Artist Artist { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}