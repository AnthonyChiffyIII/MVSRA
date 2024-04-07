using MudBlazor;
using MVSRA.Shared.EFModels;

namespace MVSRA.Shared.Modules;

public interface IPhotoRepository
{
    Task UploadPhotos(List<Photo> photos);

    Task DeletePhoto(Photo photo);

    Task<List<Photo>> GetPhotos(int take);

    Task<List<Photo>> QueryPhotos(string searchString, TableState state);
}
