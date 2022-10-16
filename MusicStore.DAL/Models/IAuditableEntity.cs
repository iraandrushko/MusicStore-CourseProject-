using System;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.DAL.Models
{
    public interface IAuditableEntity
    {
        [Required]
        public DateTime CreatedDate { get; set; } 

        [Required]
        public DateTime UpdatedDate { get; set; }
    }
}
