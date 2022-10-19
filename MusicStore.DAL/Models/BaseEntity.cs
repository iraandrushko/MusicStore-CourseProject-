using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.DAL.Models
{
    public class BaseEntity : IAuditableEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
