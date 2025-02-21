using RealEstate.Models;

namespace RealEstate.Interfaces.ICrudServices;

public interface IEstateCrudService
{
    /*TODO: Buraya özel çağrılar için olanları implement et. Bina yaşına Göre al vs vs gibi*/
    
    public Task<Estate> Get(Guid id);
    public Task<List<Estate>> GetAll();
    public Task<Estate> Create(Estate estate);
    public Task<Estate> Update(Guid id, Estate estate);
    public Task<Estate> Delete(Guid id);
}