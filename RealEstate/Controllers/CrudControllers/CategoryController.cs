using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Interfaces.ICrudServices;

namespace RealEstate.Controllers.CrudControllers;

[ApiController]
[Route("[controller]")]
public class CategoryController: ControllerBase
{
    private readonly ICategoryCrudService _categoryCrudService;
    private readonly IMapper _mapper;
    public CategoryController(ICategoryCrudService categoryCrudService, IMapper mapper)
    {
        _categoryCrudService = categoryCrudService;
        _mapper = mapper;
    }
    /*TODO: Endpointler Implement Edilecek*/
}