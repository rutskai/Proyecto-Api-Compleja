using System.Net.Http.Json;
using Models;
using Validations;


namespace Functions
{
    class GetScore
    {
        public static async Task<Score> GetScoreAsync()
        {
            try
            {
                
            Score score= await GetApiScores.GetApiScoreAsync();
            return score;

            }
            catch (Exception ex)
            {
                 Console.WriteLine($"Error accediendo al API: {ex.Message}");
                   return new Score();
            }
        }
    }
}