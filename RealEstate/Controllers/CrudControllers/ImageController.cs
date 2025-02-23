using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Interfaces.ICrudServices;

namespace RealEstate.Controllers.CrudControllers;

[ApiController]
[Route("[controller]")]
public class ImageController: ControllerBase
{
    private readonly IImageCrudService _imageCrudService;
    private readonly IMapper _mapper;

    public ImageController(IImageCrudService imageCrudService, IMapper mapper)
    {
        _imageCrudService = imageCrudService;
        _mapper = mapper;
    }


}