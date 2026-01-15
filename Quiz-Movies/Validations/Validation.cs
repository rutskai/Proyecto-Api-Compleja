using Models;
using System.Text.RegularExpressions;


namespace Validations
{
     /**
     * @class GeneralValidation
     * Clase que contiene métodos de validación generales para nombres, películas, listas de películas y puntuaciones.
     */
    class GeneralValidation
    {
        /**
         * Valida que un nombre ingresado contenga solo letras.
         * Si el nombre no es válido, solicita al usuario volver a ingresarlo.
         *
         * @param name El nombre a validar.
         * @return string El nombre válido ya formateado.
         */

        public static string IsValid(string name)
        {
            name = name.Trim();

            if (!CheckName(name))
            {
                Console.WriteLine("Error, esrciba un carácter válido:");
                return IsValid(Console.ReadLine() ?? "");
            }

            return name;
        }

           /**
         * Comprueba si un nombre es válido, es decir, no está vacío y contiene solo letras.
         *
         * @param name El nombre a comprobar.
         * @return bool True si el nombre es válido, false en caso contrario.
         */

          public static bool CheckName(string name) => !string.IsNullOrEmpty(name) && Regex.IsMatch(name, @"^[a-zA-Z]+$");

           /**
         * Valida que una lista de películas no sea nula ni esté vacía.
         *
         * @param movies La lista de películas a validar.
         * @return bool True si la lista es válida, false en caso contrario.
         */

            public static bool IsValid(List<Movie> movies)
        {
            if (movies == null || movies.Count == 0)
            {
                return false;
            }


            return true;
        }

         /**
         * Valida que una película no sea nula y que sus propiedades esenciales no sean nulas.
         *
         * @param movie La película a validar.
         * @return bool True si la película es válida, false en caso contrario.
         */

             public static bool IsValid(Movie movie)
        {
            if (movie == null || movie.Summary==null || movie.Director==null|| movie.Genre==null)
            {
                return false;
            }
            return true;
        }

        
        /**
         * Valida que una puntuación no sea nula y que tenga un valor asignado.
         *
         * @param score La puntuación a validar.
         * @return bool True si la puntuación es válida, false en caso contrario.
         */

            public static bool IsValid(Score score)
        {
            if (score == null || score.Points==null)
            {
                return false;
            }
            return true;
        }


    }

}