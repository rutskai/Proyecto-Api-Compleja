using Models;
using Validations;

namespace Functions
{

    /**
     * @class Menu
     * Clase que gestiona el menú principal del Quiz de películas de los 90.
     */
    class Menu
    {
        /**
         * Muestra el menú principal y permite al usuario interactuar con las opciones:
         * 1) Mostrar Quiz 2) Mostrar puntuación 3) Borrar puntuación 4) Salir
         * El método seguirá mostrando el menú hasta que el usuario seleccione salir.
         * 
         * @return Task que representa la operación asincrónica de mostrar el menú.
         */
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
                
                 Console.WriteLine($"\nPuntuación: {score.Points}\n");
                 break;
                 case 3:
                 await DeleteScore.ResetScoreAsync();
                 Console.WriteLine("\nPuntuación reiniciada correctamente.\n");
                 break;
                 case 4:
                 Console.WriteLine("Saliendo...");
                 return;

                 default:
                 Console.WriteLine("Solo puedes pulsar la tecla 1, 2 o 3.\n");
                 break;
            }
         }
    }
}}