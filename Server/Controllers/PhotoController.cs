using Microsoft.AspNetCore.Mvc;
using MVSRA.Server.Modules;
using MVSRA.Server.EFModels;
using MVSRA.Server.Models;

namespace MVSRA.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PhotoController(PhotoRepository photoRepository) : Controller
{
    private readonly PhotoRepository _photoRepository = photoRepository;

    [HttpPost]
    public async Task UploadPhotos(List<Photo> photos)
    {
        await _photoRepository.UploadPhotos(photos);
    }

    [HttpPost("Delete")]
    public async Task DeletePhoto(Photo photo)
    {
        await _photoRepository.DeletePhoto(photo);
    }

    [HttpGet("{take}")]
    public async Task<List<Photo>> GetPhotos(int take = 5)
    {
        return await _photoRepository.GetPhotos(take);
    }

    [HttpPost("Query")]
    public async Task<List<Photo>> QueryPhotos(QueryTableState queryPhotosContent)
    {
        return await _photoRepository.QueryPhotos(queryPhotosContent.SearchParameter, queryPhotosContent.State);
    }
}
