using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dtos.CrudDtos;
using RealEstate.Interfaces.ICrudServices;
using RealEstate.Models;

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
    
    [HttpGet]
    public async Task<ActionResult<List<CategoryDto.Get>>> GetAll()
    {
        List<Category> categories = await _categoryCrudService.GetAll();
        List<CategoryDto.Get> dtoList = _mapper.Map<List<CategoryDto.Get>>(categories);
        return Ok(dtoList);
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<List<CategoryDto.Get>>> Get(Guid id)
    {
        Category category = await _categoryCrudService.Get(id);
        CategoryDto.Get dto = _mapper.Map<CategoryDto.Get>(category);
        return Ok(dto);
    }
    
    [HttpPost]
    public async Task<ActionResult<CategoryDto.Create>> Create(CategoryDto.Create category)
    {
        var createdCategory = await _categoryCrudService.Create(_mapper.Map<Category>(category));
        CategoryDto.Create dto = _mapper.Map<CategoryDto.Create>(createdCategory);
        return Ok(dto);
    }
    
    [HttpPut("{id}")]
    public async Task<ActionResult<CategoryDto.Update>> Update(Guid id, CategoryDto.Update category)
    {
        var updatedCategory = await _categoryCrudService.Update(id, _mapper.Map<Category>(category));
        CategoryDto.Update dto = _mapper.Map<CategoryDto.Update>(updatedCategory);
        return Ok(dto);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<CategoryDto.Delete>> Delete(Guid id)
    {
        var deletedCategory = await _categoryCrudService.Delete(id);
        CategoryDto.Delete dto = _mapper.Map<CategoryDto.Delete>(deletedCategory);
        return Ok(dto);
    }
    
    
}