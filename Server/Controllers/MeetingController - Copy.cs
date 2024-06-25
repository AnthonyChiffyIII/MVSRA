//using Microsoft.AspNetCore.Mvc;
//using MVSRA.Server.Modules;
//using MVSRA.Shared.EFModels;
//using MVSRA.Shared.Models;

//namespace MVSRA.Server.Controllers;

//[Route("api/[controller]")]
//[ApiController]
//public class Controller(MeetingRepository meetingRepository) : Controller
//{
//    private readonly MeetingRepository _meetingRepository = meetingRepository;

//    [HttpPost]
//    public async Task UploadPhotos(List<Photo> photos)
//    {
//        await _meetingRepository.UploadPhotos(photos);
//    }

//    [HttpPost("Delete")]
//    public async Task DeletePhoto(Photo photo)
//    {
//        await _meetingRepository.DeletePhoto(photo);
//    }

//    [HttpGet("{take}")]
//    public async Task<List<Photo>> GetPhotos(int take = 5)
//    {
//        return await _meetingRepository.GetPhotos(take);
//    }

//    [HttpPost("Query")]
//    public async Task<List<Photo>> QueryPhotos(QueryTableState queryPhotosContent)
//    {
//        return await _meetingRepository.QueryPhotos(queryPhotosContent.SearchParameter, queryPhotosContent.State);
//    }
//}
