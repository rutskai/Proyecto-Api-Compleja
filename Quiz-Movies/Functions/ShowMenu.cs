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
        * Al mostrar la puntuación, si esta alcanza o supera los 100 puntos, 
         * se mostrará un mensaje especial de felicitación.
         * El método seguirá mostrando el menú hasta que el usuario seleccione salir.
         * 
         * @return Task que representa la operación asincrónica de mostrar el menú.
         */
        public static async Task ShowMenu()
        {


            while (true)
            {

                Console.WriteLine("==============================\nQUIZ DE PELÍCULAS DE LOS 90\n==============================\n");
                Console.WriteLine("1) Mostrar Quiz\n2) Mostrar puntuación\n3) Borrar puntuación\n4) Salir");


                if (!int.TryParse(Console.ReadLine(), out int option))
                {
                    Console.WriteLine("Debes introducir un número válido.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        await MenuQuiz.ShowQuiz();
                        break;
                    case 2:
                        Score score = await GetScore.GetScoreAsync();

                        if (!GeneralValidation.IsValid(score))
                        {
                            Console.WriteLine("No es posible acceder a la puntuación.");
                            break;
                        }
                        Console.WriteLine($"\nPuntuación: {score.Points}\n");

                        if (score.Points >= 100)
                        {
                        Console.WriteLine("¡Felicidades! Has llegado a 100 puntos. Pat Pat.\n");
                        }
                        break;
                    case 3:
                        await DeleteScore.ResetScoreAsync();
                        Console.WriteLine("\nPuntuación reiniciada correctamente.\n");
                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        return;

                    default:
                        Console.WriteLine("Solo puedes pulsar la tecla 1, 2, 3 o 4.\n");
                        break;
                }  
            }
        }
    }
}