using System.ComponentModel.DataAnnotations;

namespace RealEstate.Models
{
    public class Image
    {
        [Key] public Guid Id { get; set; }
        [Required, MaxLength(200)] public Guid EstateId { get; set; }
        [Required, MaxLength(1000)] public required string ImageUrl { get; set; }
        [Required, MaxLength(1000)] public required string ImagePath { get; set; }
        public bool IsPrimary { get; set; }
        public int ImageOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        
        public virtual Estate Estate { get; set; } = null!;

    }
}
