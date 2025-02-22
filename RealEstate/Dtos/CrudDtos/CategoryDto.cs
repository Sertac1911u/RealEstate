using System.ComponentModel.DataAnnotations;

namespace RealEstate.Dtos.CrudDtos;

public class CategoryDto
{
    public class Get
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class Create
    {
        [Required] [MaxLength(60)] public string Name { get; set; } = null!;
    }

    public class Update
    {
        [Required] public Guid Id { get; set; }

        [MaxLength(60)] public string? Name { get; set; }
    }

    public class Delete
    {
        [Required] public Guid Id { get; set; }
    }
}