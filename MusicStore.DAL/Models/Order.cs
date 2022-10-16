using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicStore.DAL.Models
{
    public class Order : BaseEntity
    {
        [Required]
        public virtual User User { get; set; }

        [Required]
        public virtual Album Album { get; set; }
    }
}
