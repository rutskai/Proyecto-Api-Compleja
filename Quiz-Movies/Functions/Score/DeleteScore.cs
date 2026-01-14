using System.Net.Http.Json;
using Validations;


namespace Functions
{
    class DeleteScore
    {

        private static readonly HttpClient client = new HttpClient();

        public static async Task ResetScoreAsync()
        {

            try
            {
                await client.DeleteAsync("http://localhost:3000/scores/reset");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error accediendo al API: {ex.Message}");
                
            }
        }
    }
}