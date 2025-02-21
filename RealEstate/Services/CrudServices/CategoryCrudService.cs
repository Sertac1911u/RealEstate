using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using RealEstate.Exceptions;
using RealEstate.Interfaces.ICrudServices;
using RealEstate.Models;

namespace RealEstate.Services.CrudServices;

public class CategoryCrudService : ICategoryCrudService
{
    private readonly ApplicationDbContext _context;

    public CategoryCrudService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Category> Get(Guid id)
    {
        Category category = await _context.Categories.FindAsync(id) ?? throw new DbException.NotFoundException("Category not found");
        return category;
    }

    public async Task<List<Category>> GetAll()
    {
        List<Category> categories = await _context.Categories.ToListAsync();
        return categories;
    }

    public async Task<Category> Create(Category category)
    {
        await _context.Categories.AddAsync(category);
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task<Category> Update(Guid id, Category category)
    {
        _context.Categories.Update(category);
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task<Category> Delete(Guid id)
    {
        Category category = await _context.Categories.FindAsync(id)
                            ?? throw new DbException.NotFoundException("Category not found");

        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();
        return category;
    }
}