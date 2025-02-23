using RealEstate.Data;
using RealEstate.Interfaces.ICrudServices;
using RealEstate.Models;
using RealEstate.Exceptions;
using Microsoft.EntityFrameworkCore;


namespace RealEstate.Services.CrudServices;

public class ImageCrudService : IImageCrudService
{
    private readonly ApplicationDbContext _context;

    public ImageCrudService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Image> Create(Image image)
    {
        await _context.Images.AddAsync(image);
        await _context.SaveChangesAsync();
        return image;
    }

    public async Task<Image> Delete(Guid id)
    {
        Image image = await _context.Images.FindAsync(id) ?? throw new DbException.NotFoundException("Image Not Found");
        return image;
    }

    public async Task<IEnumerable<Image>> FullImage(Guid id)
    {
        var images = await _context.Images.Where(i => i.EstateId == id).ToListAsync();
        return images;
    }

    public async Task<Image> Get(Guid id)
    {
        Image image = await _context.Images.FindAsync(id) ?? throw new DbException.NotFoundException("Images Not Found");
        return image;
    }

    public async Task<Image> GetPrimaryImage(Guid id)
    {
        var primaryImage = await _context.Images.FirstOrDefaultAsync(i => i.EstateId == id && i.IsPrimary) ?? throw new DbException.NotFoundException($"Estated Id:{id} not found primary image");
        return primaryImage;
    }

    public async Task<bool> SetPrimaryImage(Guid estateId, Guid imageId)
    {
        var images = await _context.Images.Where(i => i.EstateId == estateId).ToListAsync() ?? throw new DbException.NotFoundException("There are no images");

        var targetimage = images.FirstOrDefault(i => i.Id == imageId) ?? throw new DbException.NotFoundException("There is no target image to set primary image");

        foreach (var image in images)
        {
            image.IsPrimary = false;
        }
        targetimage.IsPrimary = true;

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<Image> Update(Guid id, Image image)
    {
        _context.Images.Update(image);
        await _context.SaveChangesAsync();
        return image;
    }
}