using RealEstate.Models;

namespace RealEstate.Interfaces.ICrudServices;

public interface ICategoryCrudService
{
    public Task<Category> Get(Guid id);
    public Task<List<Category>> GetAll();
    public Task<Category> Create(Category category);
    public Task<Category> Update(Guid id, Category category);
    public Task<Category> Delete(Guid id);
}