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
        string content = JsonSerializer.Serialize(photos);
        byte[] buffer = Encoding.UTF8.GetBytes(content);
        ByteArrayContent byteContent = new(buffer);
        byteContent.Headers.ContentType = new("application/json");

        HttpResponseMessage response = await _httpClient.PostAsync("/api/Photo", byteContent);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error getting photos: {response.StatusCode}");
        }
    }

    public async Task DeletePhoto(Photo photo)
    {
        string content = JsonSerializer.Serialize(photo);
        byte[] buffer = Encoding.UTF8.GetBytes(content);
        ByteArrayContent byteContent = new(buffer);
        byteContent.Headers.ContentType = new("application/json");

        HttpResponseMessage response = await _httpClient.PostAsync("/api/Photo/Delete", byteContent);

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
            string content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Photo>>(content) ?? [];
        }
        else
        {
            // Handle unsuccessful response (e.g., log error)
            throw new Exception($"Error getting photos: {response.StatusCode}");
        }
    }

    public async Task<List<Photo>> QueryPhotos(string searchString, TableState state)
    {
        QueryPhotosContent queryPhotoContent = new(searchString, state);
        string content = JsonSerializer.Serialize(queryPhotoContent);
        byte[] buffer = Encoding.UTF8.GetBytes(content);
        ByteArrayContent byteContent = new(buffer);
        byteContent.Headers.ContentType = new("application/json");

        HttpResponseMessage response = await _httpClient.PostAsync("/api/Photo/Query", byteContent);

        if (response.IsSuccessStatusCode)
        {
            string responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Photo>>(responseContent) ?? [];
        }
        else
        {
            // Handle unsuccessful response (e.g., log error)
            throw new Exception($"Error getting photos: {response.StatusCode}");
        }
    }
}
