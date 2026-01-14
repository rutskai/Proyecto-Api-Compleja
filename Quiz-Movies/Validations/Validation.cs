using Models;
using System.Text.RegularExpressions;


namespace Validations
{
    class GeneralValidation
    {
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

          public static bool CheckName(string name) => !string.IsNullOrEmpty(name) && Regex.IsMatch(name, @"^[a-zA-Z]+$");

            public static bool IsValid(List<Movie> movies)
        {
            if (movies == null || movies.Count == 0)
            {
                return false;
            }


            return true;
        }

             public static bool IsValid(Movie movie)
        {
            if (movie == null)
            {
                return false;
            }
            return true;
        }

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