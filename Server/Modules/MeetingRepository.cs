using Microsoft.EntityFrameworkCore;
using MVSRA.Server.EFContext;
using MVSRA.Server.EFModels;
using MVSRA.Server.Modules;

namespace MVSRA.Server.Modules;

public class MeetingRepository(IDbContextFactory<MVSRAContext> contextFactory) : IMeetingRepository
{
    private readonly IDbContextFactory<MVSRAContext> _contextFactory = contextFactory;

    public async Task AddMeetings(List<Meeting> meetings)
    {
        using MVSRAContext context = await _contextFactory.CreateDbContextAsync();

        context.Meetings.AddRange(meetings);
        await context.SaveChangesAsync();
    }

    public async Task RemoveMeetings(Meeting meeting)
    {
        using MVSRAContext context = await _contextFactory.CreateDbContextAsync();

        context.Meetings.Remove(meeting);
        await context.SaveChangesAsync();
    }

    public async Task<Meeting> GetNextMeeting()
    {
        using MVSRAContext context = await _contextFactory.CreateDbContextAsync();

        DateOnly today = DateOnly.FromDateTime(DateTime.Now);

        Meeting? nextMeeting = await context.Meetings.Where(x => today <= x.Date)
            .OrderBy(x => x.Date)
            .FirstOrDefaultAsync();

        if (nextMeeting is not null)
        {
            return nextMeeting;
        }
        return new();
    }

    public async Task<List<Meeting>> GetMeetingRange(DateOnly startDate, DateOnly endDate)
    {
        using MVSRAContext context = await _contextFactory.CreateDbContextAsync();

        List<Meeting> results = await context.Meetings.Where(x => startDate <= x.Date && x.Date <= endDate)
            .OrderBy(x => x.Date)
            .ToListAsync();

        return results;
    }
}
