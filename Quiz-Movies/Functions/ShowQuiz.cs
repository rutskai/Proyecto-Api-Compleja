using Models;
using static Validations.GeneralValidation;
using static Functions.GetMovies;

namespace Functions
{
    class MenuQuiz
    {
        public static async Task showQuiz()
        {
            string option="";
            while (option.ToLower()!="n")
            {


                Movie? movie = await GetRandomMovieAsync();
                if (movie is null || !IsValid(movie))
                {
                    Console.WriteLine("No se ha podido acceder al contenido.");
                    return;
                }

                Console.WriteLine("==============================\nQUIZ DE PELÍCULAS DE LOS 90\n==============================");
                Console.WriteLine("\nMini resumen:");
                Console.WriteLine($"{movie.Summary}");
                Console.WriteLine("\nCuál es el nombre de la película?");
                string answer = Console.ReadLine() ?? "";

                string result = await ValidateAnswer.Check(answer, movie);
                Console.WriteLine(result);

                Console.WriteLine("\nEscribe 'n' para salir, o cualquier otra letra para continuar:");
                option=Console.ReadLine() ?? "";
                
            }

            Console.WriteLine("\nSaliendo del Quiz...\n");

        }
    }
}