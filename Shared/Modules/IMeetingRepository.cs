using MVSRA.Shared.EFModels;

namespace MVSRA.Shared.Modules;

public interface IMeetingRepository
{
    Task AddMeetings(List<Meeting> meetings);

    Task RemoveMeetings(Meeting meeting);

    Task<Meeting> GetNextMeeting();

    Task<List<Meeting>> GetMeetingRange(DateOnly startDate, DateOnly endDate);
}
