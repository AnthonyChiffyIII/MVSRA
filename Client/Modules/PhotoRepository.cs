using MudBlazor;
using MVSRA.Shared.EFModels;
using MVSRA.Shared.Models;
using MVSRA.Shared.Modules;
using System.Text;
using System.Text.Json;

namespace MVSRA.Client.Modules;

public class PhotoRepository(HttpClient httpClient) : IPhotoRepository
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task UploadPhotos(List<Photo> photos)
    {
        string json = JsonSerializer.Serialize(photos, DefaultSerializer.Options);
        StringContent content = new(json, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await _httpClient.PostAsync("/api/Photo", content);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error getting photos: {response.StatusCode}");
        }
    }

    public async Task DeletePhoto(Photo photo)
    {
        string json = JsonSerializer.Serialize(photo, DefaultSerializer.Options);
        StringContent content = new(json, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await _httpClient.PostAsync("/api/Photo/Delete", content);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error getting photos: {response.StatusCode}");
        }
    }

    public async Task<List<Photo>> GetPhotos(int take)
    {
        HttpResponseMessage response = await _httpClient.GetAsync($"/api/Photo/{take}");

        if (response.IsSuccessStatusCode)
        {
            string responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Photo>>(responseContent, DefaultSerializer.Options) ?? [];
        }
        else
        {
            // Handle unsuccessful response (e.g., log error)
            throw new Exception($"Error getting photos: {response.StatusCode}");
        }
    }

    public async Task<List<Photo>> QueryPhotos(string searchString, TableState state)
    {
        QueryTableState queryPhotoContent = new(searchString, state);
        string json = JsonSerializer.Serialize(queryPhotoContent, DefaultSerializer.Options);
        StringContent content = new(json, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await _httpClient.PostAsync("/api/Photo/Query", content);

        if (response.IsSuccessStatusCode)
        {
            string responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Photo>>(responseContent, DefaultSerializer.Options) ?? [];
        }
        else
        {
            // Handle unsuccessful response (e.g., log error)
            throw new Exception($"Error getting photos: {response.StatusCode}");
        }
    }
}
