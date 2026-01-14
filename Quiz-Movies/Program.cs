using System.Diagnostics;
using  Functions;

class Program
{

    static async Task Main(string[] args)
    {
        try
        {
            Process.Start("node", @"./Api/routes/server.js");
            await Task.Delay(2000);
            await Menu.showMenu();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ocurrió un error en la aplicación: {e}");
        }
    }
}