using Models;
using Validations;

namespace Functions
{
    /**
     * @class ValidateAnswer
     * Clase que se encarga de validar la respuesta del usuario en el quiz de películas.
     */
    class ValidateAnswer
    {
          /**
         * Compara la respuesta del usuario con el título de la película.
         * Si la respuesta es correcta, actualiza la puntuación.
         *
         * @param answer La respuesta ingresada por el usuario.
         * @param movie La película actual que se está evaluando.
         * @return Task<string> Un mensaje indicando si la respuesta fue correcta o incorrecta, con detalles de la película.
         */

        public static async Task<string> Check(string answer, Movie movie)
        {

            if (!GeneralValidation.IsValid(movie))
            {
                return "No se pudo acceder a las propiedades de la película.";
            }

            if (answer.Trim().ToLower() == movie.Title.Trim().ToLower())
            {
                await UpdateScore.UpdateScoreAsync();
                return "\nResultado:\n ¡Correcto!\n\nDetalles:\nDirector: {movie.Director}\nGénero: {movie.Genre}\nAño: {movie.Year}";
            }
            else
            {
                return $"\nIncorrecto.\nRespuesta correcta: {movie.Title}\n\nDetalles:\nDirector: {movie.Director}\nGénero: {movie.Genre}\nAño: {movie.Year}";

            }
        }

    }

}

