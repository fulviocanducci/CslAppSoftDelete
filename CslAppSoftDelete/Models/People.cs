using Canducci.SoftDelete;
using System;

namespace CslAppSoftDelete.Models
{
    public class People : ISoftDeleteDateTime
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DeletedAt { get; } = null;
    }
}
