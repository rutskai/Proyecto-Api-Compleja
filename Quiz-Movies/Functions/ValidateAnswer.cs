using System.Threading.Tasks;
using Models;

namespace Functions
{

    class ValidateAnswer
    {

        public static async Task<string> Check(string answer, Movie movie)
        {

            if (answer.Trim().ToLower() == movie.Title.Trim().ToLower())
            {
                await UpdateScore.UpdateScoreAsync();
                return "\nResultado:\n ¡Correcto!";
            }
            else
            {
                return $"Incorrecto. La respuesta correcta es: {movie.Title}";
            }
        }

    }

}

