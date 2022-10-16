using System;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.DAL.Models
{
    public class Genre : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }
    }
}