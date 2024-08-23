using Seido.Utilities.SeedGenerator;
namespace GU1_Zoo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Zoo!");

        /*
        var rnd = new csSeedGenerator();
        var a1 = new csAnimal(rnd);
        Console.WriteLine(a1);
        */


        
        var n = new csZoo(5, "Small Zoo");
        Console.WriteLine(n);

        var n1 = new csZoo(25, "Large Zoo");
        Console.WriteLine(n1);

        
        var refZoo = new csZoo();
        Console.WriteLine(refZoo);
        
    }
}

