using Models;
using static Validations.GeneralValidation;
using static Functions.GetMovies;

namespace Functions
{

     /**
     * @class MenuQuiz
     * Clase que gestiona el quiz de películas de los 90.
     */
     
    class MenuQuiz
    {

        /**
         * Muestra una película aleatoria de los 90 y permite al usuario adivinar su nombre.
         * Después de cada intento, se muestra si la respuesta es correcta o incorrecta.
         * El quiz continúa hasta que el usuario escriba 'n' para salir.
         *
         * @return Task que representa la operación asincrónica de mostrar el quiz.
         */

        public static async Task ShowQuiz()
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