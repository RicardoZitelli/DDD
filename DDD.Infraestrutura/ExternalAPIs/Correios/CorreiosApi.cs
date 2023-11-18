using System.Text;
using System.Net.Http.Headers;
using System.Text.Json;
using DDD.Domain.Services.Interfaces;
using DDD.Domain.Entities;

namespace DDD.Infrastructure.ExternalAPIs.Correios;

public class CorreiosApi : Base, IServiceCorreiosApi
{
    public async Task<CorreiosToken> GetToken(string url, string username, string password)
    {
        try
        {
            using HttpClient client = new();

            var byteArray = Encoding.UTF8.GetBytes($"{username}:{password}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var content = new StringContent("", Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(url, content);

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Status Code: {response.StatusCode} - Reason: {response.ReasonPhrase}");

            return JsonSerializer.Deserialize<CorreiosToken>(await response.Content.ReadAsStringAsync());
        }
        catch (ArgumentNullException)
        {
            throw;
        }
        catch (JsonException)
        {
            throw;
        }
        catch (NotSupportedException)
        {
            throw;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
