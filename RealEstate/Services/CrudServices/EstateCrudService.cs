using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using RealEstate.Exceptions;
using RealEstate.Interfaces.ICrudServices;
using RealEstate.Models;

namespace RealEstate.Services.CrudServices;

public class EstateCrudService: IEstateCrudService
{
    
    private readonly ApplicationDbContext _context;
    public EstateCrudService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<Estate> Get(Guid id)
    {
        Estate estate = await _context.Estates.FindAsync(id) ?? throw new DbException.NotFoundException("Estate not found");
        return estate;
    }

    public async Task<List<Estate>> GetAll()
    {
        List<Estate> estates = await _context.Estates.ToListAsync();
        return estates;
    }

    public async Task<Estate> Create(Estate estate)
    {
        await _context.Estates.AddAsync(estate);
        await _context.SaveChangesAsync();
        return estate;
    }

    public async Task<Estate> Update(Guid id, Estate estate)
    {
        //_context.Entry(estate).State = EntityState.Modified;
        _context.Estates.Update(estate);
        await _context.SaveChangesAsync();
        return estate;
    }

    public async  Task<Estate> Delete(Guid id)
    {
        var estate = await _context.Estates.FindAsync(id) ??
                       throw new DbException.NotFoundException("Item Not Found on the database");

        _context.Estates.Remove(estate);
        await _context.SaveChangesAsync();

        return estate;
    }
}