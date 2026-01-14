using Models;
using Validations;

namespace Functions
{


    class Menu
    {
        public static async Task showMenu()
        {
            int option=-1;

            while (option!=0)
            {
            
            Console.WriteLine("==============================\nQUIZ DE PELÍCULAS DE LOS 90\n==============================\n");
            Console.WriteLine("1) Mostrar Quiz\n2) Mostrar puntuación\n3) Borrar puntuación\n4) Salir");
          
            
            if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Debes introducir un número válido.");
                    continue;
                }

            switch (option)
            {
                 case 1:
                 await MenuQuiz.showQuiz();
                 break;
                 case 2:
                 Score score = await GetScore.GetScoreAsync();
                        if (!GeneralValidation.IsValid(score))
                        {
                            Console.WriteLine("No es posible acceder a la puntuación.");
                            return;
                        }
                 Console.WriteLine($"Puntuación: {score.Points}");
                 break;
                 case 3:
                 await DeleteScore.ResetScoreAsync();
                 break;
                 case 4:
                 Console.WriteLine("Saliendo...");
                 return;

                 default:
                 Console.WriteLine("Solo puedes pulsar la tecla 1, 2 o 3.");
                 break;
            }
         }
    }
}}