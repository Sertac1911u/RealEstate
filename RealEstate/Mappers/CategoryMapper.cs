using AutoMapper;
using RealEstate.Dtos.CrudDtos;
using RealEstate.Models;

namespace RealEstate.Mappers;

public class CategoryMapper: Profile
{
    public CategoryMapper()
    {
        CreateMap<Category, CategoryDto>();
        CreateMap<CategoryDto, Category>();
        
        CreateMap<Category, CategoryDto.Get>();
        CreateMap<CategoryDto.Get, Category>();
        
        CreateMap<Category, CategoryDto.Create>();
        CreateMap<CategoryDto.Create, Category>();
        
        CreateMap<Category, CategoryDto.Update>();
        CreateMap<CategoryDto.Update, Category>();
        
        CreateMap<Category, CategoryDto.Delete>();
        CreateMap<CategoryDto.Delete, Category>();
    }
}