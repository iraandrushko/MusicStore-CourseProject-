using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.DAL.Models
{
    public class Artist : BaseEntity
    {
        public virtual IEnumerable<Album> Albums { get; set; }

        [Required] [StringLength(50)]
        public string Name { get; set; }

    }
}
