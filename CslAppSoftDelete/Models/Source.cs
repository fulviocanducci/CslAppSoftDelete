using Canducci.SoftDelete;

namespace CslAppSoftDelete.Models
{
    public class Source : ISoftDeleteBool
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool DeletedAt { get; } = false;
    }
}
