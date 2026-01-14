using System.Net.Http;
using System.Net.Http.Json;
using Models;
using Validations;
using System.Threading.Tasks;

namespace Functions
{
    class UpdateScore
    {
        
        private static readonly HttpClient client = new HttpClient();

        public static async Task UpdateScoreAsync()
        {
        try
            {
                var response = await client.PostAsync("http://localhost:3000/scores/update", null);
                response.EnsureSuccessStatusCode();

                await response.Content.ReadFromJsonAsync<Score>();
               
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error accediendo al API: {ex.Message}");
            }

        }
    }
}