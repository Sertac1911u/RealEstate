using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dtos.CrudDtos;
using RealEstate.Interfaces.ICrudServices;
using RealEstate.Models;

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

    [HttpGet]
    public async Task<ActionResult<List<EstateDto.Get>>> GetAll()
    {
        List<Estate> estates = await _estateCrudService.GetAll();
        List<EstateDto.Get> dtoList = _mapper.Map<List<EstateDto.Get>>(estates);
        return Ok(dtoList);
    }

    // Belirtilen id'ye ait Estate'yi getirme
    [HttpGet("{id}")]
    public async Task<ActionResult<EstateDto.Get>> Get(Guid id)
    {
        Estate estate = await _estateCrudService.Get(id);
        EstateDto.Get dto = _mapper.Map<EstateDto.Get>(estate);
        return Ok(dto);
    }

    // Yeni Estate oluşturma
    [HttpPost]
    public async Task<ActionResult<EstateDto.Create>> Create(EstateDto.Create estateDto)
    {
        Estate estate = _mapper.Map<Estate>(estateDto);
        Estate createdEstate = await _estateCrudService.Create(estate);
        EstateDto.Create createdDto = _mapper.Map<EstateDto.Create>(createdEstate);
        return Ok(createdDto);
    }

    // Var olan Estate'yi güncelleme
    [HttpPut("{id}")]
    public async Task<ActionResult<EstateDto.Update>> Update(Guid id, EstateDto.Update estateDto)
    {
        Estate estate = _mapper.Map<Estate>(estateDto);
        Estate updatedEstate = await _estateCrudService.Update(id, estate);
        EstateDto.Update updatedDto = _mapper.Map<EstateDto.Update>(updatedEstate);
        return Ok(updatedDto);
    }

    // Belirtilen id'ye ait Estate'yi silme
    [HttpDelete("{id}")]
    public async Task<ActionResult<EstateDto.Delete>> Delete(Guid id)
    {
        Estate deletedEstate = await _estateCrudService.Delete(id);
        EstateDto.Delete deletedDto = _mapper.Map<EstateDto.Delete>(deletedEstate);
        return Ok(deletedDto);
    }
}