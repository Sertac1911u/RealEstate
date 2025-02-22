using AutoMapper;
using RealEstate.Dtos.CrudDtos;
using RealEstate.Models;

namespace RealEstate.Mappers;

public class EstateMapper: Profile
{
    EstateMapper()
    {
        CreateMap<Estate, EstateDto>();
        CreateMap<EstateDto, Estate>();
        
        CreateMap<Estate, EstateDto.Get>();
        CreateMap<EstateDto.Get, Estate>();
        
        CreateMap<Estate, EstateDto.Create>();
        CreateMap<EstateDto.Create, Estate>();
        
        CreateMap<Estate, EstateDto.Update>();
        CreateMap<EstateDto.Update, Estate>();
        
        CreateMap<Estate, EstateDto.Delete>();
        CreateMap<EstateDto.Delete, Estate>();
    }
}