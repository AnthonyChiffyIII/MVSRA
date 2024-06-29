using MVSRA.Shared.EFModels;
using MVSRA.Shared.Modules;
using System.Text;
using System.Text.Json;

namespace MVSRA.Client.Modules;

public class MeetingRepository(HttpClient httpClient) : IMeetingRepository
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task AddMeetings(List<Meeting> meetings)
    {
        string json = JsonSerializer.Serialize(meetings, DefaultSerializer.Options);
        StringContent content = new(json, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await _httpClient.PostAsync("/api/Meeting", content);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error getting meetings: {response.StatusCode}");
        }
    }

    public async Task RemoveMeetings(Meeting meeting)
    {
        string json = JsonSerializer.Serialize(meeting, DefaultSerializer.Options);
        StringContent content = new(json, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await _httpClient.PostAsync("/api/Meeting/Delete", content);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error getting meetings: {response.StatusCode}");
        }
    }

    public async Task<Meeting> GetNextMeeting()
    {
        HttpResponseMessage response = await _httpClient.GetAsync($"/api/Meeting/Next");

        if (response.IsSuccessStatusCode)
        {
            string responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Meeting>(responseContent, DefaultSerializer.Options) ?? new();
        }
        else
        {
            // Handle unsuccessful response (e.g., log error)
            throw new Exception($"Error getting meetings: {response.StatusCode}");
        }
    }

    public async Task<List<Meeting>> GetMeetingRange(DateOnly startDate, DateOnly endDate)
    {
        HttpResponseMessage response = await _httpClient.GetAsync($"/api/Meeting/{startDate:yyyy-MM-dd}/{endDate:yyyy-MM-dd}");

        if (response.IsSuccessStatusCode)
        {
            string responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Meeting>>(responseContent, DefaultSerializer.Options) ?? [];
        }
        else
        {
            // Handle unsuccessful response (e.g., log error)
            throw new Exception($"Error getting meetings: {response.StatusCode}");
        }
    }
}
