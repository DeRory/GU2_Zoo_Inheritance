using Seido.Utilities.SeedGenerator;
namespace GU1_Zoo;

class Program
{
    static void Main(string[] args)
    {
        // Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("---------------------");
        Console.WriteLine("\nWelcome to Martins Zoo's\n");
        
        var rnd = new csSeedGenerator();
        
        // Skapa instanser av olika zoo
        Console.ForegroundColor = ConsoleColor.Red;
        var africanZoo = new csAfricanZoo(); // Afrikanskt zoo med slumpmässigt antal djur
        Console.WriteLine(africanZoo);

        Console.ForegroundColor = ConsoleColor.Blue;
        var nordicZoo = new csNordicZoo(); // Nordiskt zoo med slumpmässigt antal djur
        Console.WriteLine(nordicZoo);

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        var birdZoo = new csBirdZoo(); // Fågelzoo med slumpmässigt antal djur
        Console.WriteLine(birdZoo);

        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine("\nSmall Zoo");
        var n = new csZoo(5, "");
        Console.WriteLine(n);

        Console.ForegroundColor = ConsoleColor.Magenta;
        System.Console.WriteLine("\nLarge Zoo");
        var n1 = new csZoo(25, "");
        Console.WriteLine(n1);
    }
}

