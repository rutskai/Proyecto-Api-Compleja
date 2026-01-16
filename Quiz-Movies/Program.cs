using System.Diagnostics;
using  Functions;

/**
 * @class Program
 * Clase principal de la aplicación que inicia el servidor Node.js y muestra el menú del quiz.
 */

class Program
{
    /**
     * Método de entrada principal de la aplicación.
     * 
     * Inicia el servidor Node.js ejecutando el archivo "server.js" y espera 2 segundos
     * para asegurar que el servidor esté corriendo antes de mostrar el menú principal.
     * Luego, llama al método Menu.showMenu() para interactuar con el usuario.
     *
     * Captura cualquier excepción que ocurra durante la ejecución y la muestra en consola.
     *
     * @param args Argumentos de línea de comandos (no utilizados en esta aplicación).
     * @return Task Representa la operación asincrónica del método Main.
     */

    static async Task Main(string[] args)
    {
        try
        {
            Process.Start("node", @"./Api/routes/server.js");
            await Task.Delay(2000);
            await Menu.ShowMenu();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ocurrió un error en la aplicación: {e}");
        }
    }
}