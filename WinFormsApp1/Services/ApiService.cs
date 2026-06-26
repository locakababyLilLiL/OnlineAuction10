using System.Net.Http;
using System.Net.Http.Json;
using WinFormsApp1.Models;

public class ApiService
{
    private HttpClient _client;

    public ApiService()
    {
        _client = new HttpClient();
        _client.BaseAddress = new Uri("https://localhost:5001/");
    }

    public async Task<LoginResponse> Login(string username, string password)
    {
        var res = await _client.PostAsJsonAsync("api/auth/login", new
        {
            username,
            password
        });

        return await res.Content.ReadFromJsonAsync<LoginResponse>();
    }

    public async Task<List<Auction>> GetAuctions()
    {
        return await _client.GetFromJsonAsync<List<Auction>>("api/auctions/active");
    }

    public async Task<List<BidHistory>> GetHistory(int auctionId)
    {
        return await _client.GetFromJsonAsync<List<BidHistory>>($"api/auctions/{auctionId}/history");
    }
}