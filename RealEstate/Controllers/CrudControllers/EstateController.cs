using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Interfaces.ICrudServices;

namespace RealEstate.Controllers.CrudControllers;

[ApiController]
[Route("[controller]")]
public class EstateController: ControllerBase
{
    private readonly IEstateCrudService _estateCrudService;
    private readonly IMapper _mapper;
    public EstateController(IEstateCrudService estateCrudService, IMapper mapper)
    {
        _estateCrudService = estateCrudService;
        _mapper = mapper;
    }
    
    /*TODO: Endpointler Implement Edilecek*/
    
    
    
}