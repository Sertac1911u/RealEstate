using System.ComponentModel.DataAnnotations;

namespace RealEstate.Models
{
    public class Category
    {
        [Key] public Guid Id { get; set; }
        [Required, MaxLength(60)] public required string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
        public virtual ICollection<Estate> Estates { get; set; } = new List<Estate>();

    }
}
