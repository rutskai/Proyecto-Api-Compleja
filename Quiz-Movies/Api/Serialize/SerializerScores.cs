using System.Text.Json;
using Models;
using static Validations.GeneralValidation;

namespace Functions
{
    class GetApiScores
    {
        public static async Task<Score> GetApiScoreAsync()
        {
            try
            {
                using HttpClient client = new HttpClient();

                string url = "http://localhost:3000/scores";

                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();

             
                var score = JsonSerializer.Deserialize<Score>(content) ?? new Score();

                if (!IsValid(score))
                {
                    Console.WriteLine("Error al acceder al score.");
                    return new Score();
                }

                return score;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accediendo al API de scores: " + e.Message);
                return new Score();
            }
        }
    }
}
