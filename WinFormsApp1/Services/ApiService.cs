using System.Net.Http;
using System.Net.Http.Json;
using WinFormsApp1.Models;

namespace WinFormsApp1.Services
{
    public class ApiService
    {
        private readonly HttpClient _client;

        public ApiService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:5001/");
        }

        // Đăng nhập
        public async Task<LoginResponse?> Login(string username, string password)
        {
            var res = await _client.PostAsJsonAsync("api/auth/login", new { username, password });
            if (!res.IsSuccessStatusCode) return null;
            return await res.Content.ReadFromJsonAsync<LoginResponse>();
        }

        // Đăng ký
        public async Task<bool> Register(string username, string password, string fullName)
        {
            var res = await _client.PostAsJsonAsync("api/auth/register", new { username, password, fullName });
            return res.IsSuccessStatusCode;
        }

        // Lấy danh sách phiên đấu giá
        public async Task<List<Auction>> GetAuctions()
        {
            return await _client.GetFromJsonAsync<List<Auction>>("api/auctions/active")
                   ?? new List<Auction>();
        }

        // Lấy lịch sử đặt giá
        public async Task<List<BidHistory>> GetHistory(int auctionId)
        {
            return await _client.GetFromJsonAsync<List<BidHistory>>($"api/auctions/{auctionId}/history")
                   ?? new List<BidHistory>();
        }
    }
}