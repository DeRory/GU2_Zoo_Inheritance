using Seido.Utilities.SeedGenerator;
namespace GU1_Zoo;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("-------------------------");
        Console.WriteLine("\nWelcome to Martins Zoo's\n");
        
        var rnd = new csSeedGenerator();
<<<<<<< HEAD
                                                               
        Console.ForegroundColor = ConsoleColor.Red;             // Skapa instanser av olika zoo
        var africanZoo = new csAfricanZoo();                   // Afrikanskt zoo med slumpmässigt antal djur

        Console.ForegroundColor = ConsoleColor.Blue;
        var nordicZoo = new csNordicZoo();                  // Nordiskt zoo med slumpmässigt antal djur

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        var birdZoo = new csBirdZoo();                      // Fågelzoo med slumpmässigt antal djur
        
        // Console.ForegroundColor = ConsoleColor.White;
        // System.Console.WriteLine("\nSmall Zoo");
        // var n = new csZoo(5, "");
        // Console.WriteLine(n);

        // Console.ForegroundColor = ConsoleColor.Magenta;
        // System.Console.WriteLine("\nLarge Zoo");
        // var n1 = new csZoo(25, "");
        // Console.WriteLine(n1);

=======
        
        // Skapa instanser av olika zoo
        Console.ForegroundColor = ConsoleColor.Red;
        var africanZoo = new csAfricanZoo(); // Afrikanskt zoo med slumpmässigt antal djur
        // Console.WriteLine(africanZoo);

        Console.ForegroundColor = ConsoleColor.Blue;
        var nordicZoo = new csNordicZoo(); // Nordiskt zoo med slumpmässigt antal djur
        // Console.WriteLine(nordicZoo);

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        var birdZoo = new csBirdZoo(); // Fågelzoo med slumpmässigt antal djur
        // Console.WriteLine(birdZoo);

        // Console.ForegroundColor = ConsoleColor.White;
        // System.Console.WriteLine("\nSmall Zoo");
        // var n = new csZoo(5, "");
        // Console.WriteLine(n);

        // Console.ForegroundColor = ConsoleColor.Magenta;
        // System.Console.WriteLine("\nLarge Zoo");
        // var n1 = new csZoo(25, "");
        // Console.WriteLine(n1);

>>>>>>> 35b2c256cbf02094e6fe0dd4cd597a5d6183d23a
        List<csZoo> everyZoo = new List<csZoo>();
        everyZoo.Add(africanZoo);
        everyZoo.Add(nordicZoo);
        everyZoo.Add(birdZoo);

        foreach (var zoo in everyZoo)
        {
<<<<<<< HEAD
            Console.WriteLine(zoo);
        }
        Console.WriteLine("Total Zoo´s summary:\n-------------------------");
        Console.WriteLine($"{"Kilos of meat:", -20} {africanZoo.AfricanMeat, -10}");
        Console.WriteLine($"{"Number of wolves:", -20} {nordicZoo.WolfCount, -10}");
        Console.WriteLine($"{"Number of parrots:", -20} {birdZoo.ParrotCount, -10}");
        Console.WriteLine($"{"Number of Animals:", -20} {csZoo.TotalAnimalsRegistered, -10}");
        Console.WriteLine("-------------------------\n");
=======
            System.Console.WriteLine(zoo);
            
        }
        System.Console.WriteLine($"\nKilos of meat {africanZoo.AfricanMeat}");
        System.Console.WriteLine($"Number of wolves {nordicZoo.WolfCount}");
        System.Console.WriteLine($"Number of parrots {birdZoo.ParrotCount}");
>>>>>>> 35b2c256cbf02094e6fe0dd4cd597a5d6183d23a
    }
}

