using Microsoft.EntityFrameworkCore;
using MudBlazor;
using MVSRA.Server.EFContext;
using MVSRA.Shared.EFModels;
using MVSRA.Shared.Modules;

namespace MVSRA.Server.Modules;

public class PhotoRepository(IDbContextFactory<MVSRAContext> contextFactory) : IPhotoRepository
{
    private readonly IDbContextFactory<MVSRAContext> _contextFactory = contextFactory;

    public async Task UploadPhotos(List<Photo> photos)
    {
        using MVSRAContext context = await _contextFactory.CreateDbContextAsync();

        context.Photos.AddRange(photos);
        await context.SaveChangesAsync();
    }

    public async Task DeletePhoto(Photo photo)
    {
        using MVSRAContext context = await _contextFactory.CreateDbContextAsync();

        context.Photos.Remove(photo);
        await context.SaveChangesAsync();
    }

    public async Task<List<Photo>> GetPhotos(int take)
    {
        using MVSRAContext context = await _contextFactory.CreateDbContextAsync();

        return await context.Photos.Take(take).ToListAsync();
    }

    public async Task<List<Photo>> QueryPhotos(string searchString, TableState state)
    {
        using MVSRAContext context = await _contextFactory.CreateDbContextAsync();

        IQueryable<Photo> query = context.Photos.AsQueryable();

        if (searchString != null)
        {
            query = context.Photos
                .Where(x => x.Caption != null && x.Caption.Contains(searchString))
                .AsQueryable();
        }

        switch (state.SortLabel)
        {
            case "caption_field":
                query = query.OrderByDirection(state.SortDirection, o => o.Caption);
                break;
            case "upload_date_field":
                query = query.OrderByDirection(state.SortDirection, o => o.UploadDate);
                break;
            case "uploader_field":
                query = query.OrderByDirection(state.SortDirection, o => o.UploadedBy);
                break;
        }

        return await query.Skip(state.Page * state.PageSize).Take(state.PageSize).ToListAsync();
    }
}
