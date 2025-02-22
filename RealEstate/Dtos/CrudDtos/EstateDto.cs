using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RealEstate.Models;

namespace RealEstate.Dtos.CrudDtos;

public class EstateDto
{
    public class Get
    {
        [Key] public Guid Id { get; set; }

        [Required, MaxLength(200)] public required string Title { get; set; }

        public required string Description { get; set; }

        [Required, MaxLength(50)] public required string Type { get; set; }

        [ForeignKey("Category")] public Guid CategoryId { get; set; }

        public float Price { get; set; }

        public int SquareMeter { get; set; }

        [MaxLength(100)] public string? City { get; set; }

        [MaxLength(100)] public string? District { get; set; }

        [MaxLength(100)] public string? Neighborhood { get; set; }

        [MaxLength(100)] public string? Street { get; set; }

        [MaxLength(100)] public string? BuildingName { get; set; }

        public int FloorNumber { get; set; }

        public int ApartmentNumber { get; set; }

        public int Latitude { get; set; }

        public int Longitude { get; set; }

        public int BuildingAge { get; set; }

        public int RoomCount { get; set; }

        public int BathroomCount { get; set; }

        public int BalconyCount { get; set; }

        [MaxLength(50)] public required string HeatingType { get; set; }

        public bool HasElevator { get; set; }

        public bool HasParking { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
        
        public virtual Category Category { get; set; } = null!;
        
        public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    }

    public class Create
    {
        [Required, MaxLength(200)] public required string Title { get; set; }

        public required string Description { get; set; }

        [Required, MaxLength(50)] public required string Type { get; set; }

        [ForeignKey("Category")] public Guid CategoryId { get; set; }

        public float Price { get; set; }

        public int SquareMeter { get; set; }

        [MaxLength(100)] public string? City { get; set; }

        [MaxLength(100)] public string? District { get; set; }

        [MaxLength(100)] public string? Neighborhood { get; set; }

        [MaxLength(100)] public string? Street { get; set; }

        [MaxLength(100)] public string? BuildingName { get; set; }

        public int FloorNumber { get; set; }

        public int ApartmentNumber { get; set; }

        public int Latitude { get; set; }

        public int Longitude { get; set; }

        public int BuildingAge { get; set; }

        public int RoomCount { get; set; }

        public int BathroomCount { get; set; }

        public int BalconyCount { get; set; }

        [MaxLength(50)] public required string HeatingType { get; set; }

        public bool HasElevator { get; set; }

        public bool HasParking { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }

    public class Update
    {
        [Key] public Guid Id { get; set; }

        [Required, MaxLength(200)] public string? Title { get; set; }

        public string? Description { get; set; }

        [Required, MaxLength(50)] public string? Type { get; set; }

        [ForeignKey("Category")] public Guid? CategoryId { get; set; }

        public float? Price { get; set; }

        public int? SquareMeter { get; set; }

        [MaxLength(100)] public string? City { get; set; }

        [MaxLength(100)] public string? District { get; set; }

        [MaxLength(100)] public string? Neighborhood { get; set; }

        [MaxLength(100)] public string? Street { get; set; }

        [MaxLength(100)] public string? BuildingName { get; set; }

        public int? FloorNumber { get; set; }

        public int? ApartmentNumber { get; set; }

        public int? Latitude { get; set; }

        public int? Longitude { get; set; }

        public int? BuildingAge { get; set; }

        public int? RoomCount { get; set; }

        public int? BathroomCount { get; set; }

        public int? BalconyCount { get; set; }

        [MaxLength(50)] public string? HeatingType { get; set; }

        public bool? HasElevator { get; set; }

        public bool? HasParking { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }

    public class Delete
    {
        [Key] public Guid Id { get; set; }
    }
}