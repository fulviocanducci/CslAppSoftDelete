using Canducci.SoftDelete;

namespace CslAppSoftDelete.Models
{
    public class House : ISoftDeleteChar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char DeletedAt { get; } = 'N';
    }
}
