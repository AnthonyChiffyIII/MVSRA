using Microsoft.AspNetCore.Mvc;
using MVSRA.Server.Modules;
using MVSRA.Server.EFModels;
using MVSRA.Server.Models;

namespace MVSRA.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MeetingController(MeetingRepository meetingRepository) : Controller
{
    private readonly MeetingRepository _meetingRepository = meetingRepository;

    [HttpPost]
    public async Task AddMeetings(List<Meeting> meetings)
    {
        await _meetingRepository.AddMeetings(meetings);
    }

    [HttpPost("Delete")]
    public async Task RemoveMeetings(Meeting meeting)
    {
        await _meetingRepository.RemoveMeetings(meeting);
    }

    [HttpGet("Next")]
    public async Task<Meeting> GetNextMeeting()
    {
        return await _meetingRepository.GetNextMeeting();
    }

    [HttpGet("{startDate}/{endDate}")]
    public async Task<List<Meeting>> GetMeetingRange(DateOnly startDate, DateOnly endDate)
    {
        return await _meetingRepository.GetMeetingRange(startDate, endDate);
    }
}
