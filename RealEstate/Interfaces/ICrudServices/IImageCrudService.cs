using RealEstate.Models;


namespace RealEstate.Interfaces.ICrudServices
{
    public interface IImageCrudService
    {
        public Task<Image> Get(Guid id);
        public Task<IEnumerable<Image>> FullImage(Guid id);
        public Task<Image> GetPrimaryImage(Guid id);
        public Task<Image> Create(Image image);
        public Task<Image> Update(Guid id,Image image);
        public Task<Image> Delete(Guid id);
        public Task<bool> SetPrimaryImage(Guid estateId,Guid imageId);
    }
}
