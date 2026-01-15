
namespace Functions
{
     /**
     * @class DeleteScore
     * Clase encargada de reiniciar la puntuación del usuario en la API.
     */
    class DeleteScore
    {

        private static readonly HttpClient client = new HttpClient();

         /**
         * Envía una petición DELETE al endpoint "/scores/reset" para reiniciar la puntuación del usuario.
         * Captura cualquier excepción que ocurra durante la llamada a la API y muestra un mensaje en consola.
         *
         * @return Task Representa la operación asincrónica de reiniciar la puntuación.
         */
        public static async Task ResetScoreAsync()
        {

            try
            {
                await client.DeleteAsync("http://localhost:3000/scores/reset");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error accediendo al API: {ex.Message}");
                
            }
        }
    }
}