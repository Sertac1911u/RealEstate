using System.ComponentModel.DataAnnotations;

namespace RealEstate.Dtos.CrudDtos
{
    public class ImageDto
    {
        public class Get
        {
            public Guid Id { get; set; }
            public Guid EstateId { get; set; }
            public string ImageUrl { get; set; } = null!;
            public string ImagePath { get; set; } = null!;
            public bool IsPrimary { get; set; }
            public int ImageOrder { get; set; }
            public DateTime CreatedAt { get; set; }

        }
        public class Create
        {
            [Required, MaxLength(1000)] public string ImageUrl { get; set; } = null!;

            [Required, MaxLength(1000)] public string ImagePath { get; set; } = null!;

            public bool IsPrimary { get; set; } = false;

            public int ImageOrder { get; set; } = 0;
        }
        public class Update
        {
            [Required] public Guid Id { get; set; }

            [Required] public Guid EstateId { get; set; }

            [Required, MaxLength(1000)] public string ImageUrl { get; set; } = null!;

            [Required, MaxLength(1000)] public string ImagePath { get; set; } = null!;

            public bool IsPrimary { get; set; }
            public int ImageOrder { get; set; }

        }
        public class Delete
        {
            [Required] public Guid Id { get; set; }
        }
    }
}
