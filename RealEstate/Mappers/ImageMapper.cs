using AutoMapper;
using RealEstate.Dtos.CrudDtos;
using RealEstate.Models;

namespace RealEstate.Mappers
{
    public class ImageMapper : Profile
    {
        public ImageMapper()
        {
            CreateMap<Image, ImageDto>();
            CreateMap<ImageDto, Image>();

            CreateMap<Image, ImageDto.Get>();
            CreateMap<ImageDto.Get, Image>();

            CreateMap<Image, ImageDto.Create>();
            CreateMap<ImageDto.Create, Image>();

            CreateMap<Image, ImageDto.Update>();
            CreateMap<ImageDto.Update, Image>();

            CreateMap<Image, ImageDto.Delete>();
            CreateMap<ImageDto.Delete, Image>();
        }
    }
}
