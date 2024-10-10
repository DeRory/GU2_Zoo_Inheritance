using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using Seido.Utilities.SeedGenerator;

namespace GU1_Zoo
{
    public class csZoo
    {
        private static readonly List<enAnimalKind> carnivores = new List<enAnimalKind>      // carnivores
        {
            enAnimalKind.Lion,
            enAnimalKind.Aligator,
            enAnimalKind.Fox,
            enAnimalKind.Wolf
        };

        public List<csAnimal> ListOfAnimal { get; set; } = new List<csAnimal>();
        public string Name { get; set; }
        public static int TotalAnimalsRegistered { get;  set; } = 0;
        public virtual int ParrotCount { get; } = 0;
        public virtual int WolfCount { get; } = 0;
        public virtual int AfricanMeat { get; } = 0;
        public int nrZooAnimals => ListOfAnimal.Count;

        public bool AreCarnivorePresent                                                          // Controlls if carnivore is active in zoo.
        {
            get
            {
                return ListOfAnimal.Any(animal => carnivores.Contains(animal.Kind));
            }
        }
        public static int GetTotalAnimalsRegistered()                                           // tracks total animlas seeded to zooz
        {
            return TotalAnimalsRegistered;                                                      // returns
        }
        
        public override string ToString()
        {
            string sRet = "";
            string separator = new string('-', 40) + "";

            sRet += $"{"\nName", 10}{"Animal", 12}{"Mood", 8}{"Age", 8}\n";
            sRet += separator;

            foreach (var item in ListOfAnimal)
            {
                sRet += $"\n{item.Name, -10}{item.Kind, -10}{item.Mood, -10}{item.Age, -10}";
            }
            return sRet;
        }

        public csZoo(int nrAnimals, string name)
        {
            Name = name;
            var rnd = new csSeedGenerator();
            for (int i = 0; i < nrAnimals; i++)
            {
                ListOfAnimal.Add(new csAnimal(rnd));
                TotalAnimalsRegistered++;
            }
        }
        public csZoo() {}

        public virtual string Question => $"Hello???";        ///// WOLF THREAT?

    
    }

    public class csAfricanZoo : csZoo
    {
        public csAfricanZoo()
        {
            Name = "African Zoo";
            var rnd = new csSeedGenerator();

            for (enAnimalKind kind = enAnimalKind.Aligator; kind <= enAnimalKind.Monkey; kind++)
            {
                // Slumpar antalet djur mellan 1 och 5 för varje djursort
                int numberOfAnimals = rnd.Next(1, 6);

                // Lägger till slumpmässigt antal djur av varje sort
                for (int i = 0; i < numberOfAnimals; i++)
                {
                    var mood = rnd.FromEnum<enAnimalMood>(); // Slumpar ett humör för varje djur
                    ListOfAnimal.Add(new csAnimal(rnd) { Kind = kind, Mood = mood });
                    TotalAnimalsRegistered++;
                }
            }
        }

        public int AfricanMeat                                              //En metod med typen int som parameter och räknar totala meat konsumtion
        {
            get
            {
                int totalMeat = 0;                                          //Vi börjar med att säga att totala konsumtionen ligger på 0kg. 
                foreach (var nrAnimals in ListOfAnimal)                     //För varje number of animal i ListOfAnimal och om djurens kind 
                {                                                           //är samma sak som Aligator, plussa på med 10, samma för lion dock 5.
                    if (nrAnimals.Kind == enAnimalKind.Aligator)
                        totalMeat += 10;
                    else if (nrAnimals.Kind == enAnimalKind.Lion)
                        totalMeat += 5;
                }
                return totalMeat;                                           //Här returnerar vi det totala värdet
            }
        }

        public override string ToString()
        {
            string formattedAnimals = $"\n";                                 // writes output with formatting
            string separator = new string('-', 40) + "\n";
            string CarnivoreStatus = AreCarnivorePresent ? "Carnivore Present" : "No Carnivores";

            string summaryKPI =                                                             
                                $"\n{Name} Summary KPI:\n" +
                                $"-------------------------\n" +
                                $"{"Meat eaten per day:",-20}{AfricanMeat,-10}\n" +
                                $"{"Parrot registered:",-20}{ParrotCount,-10}\n" +
                                $"{"Wolves registered:",-20}{WolfCount,-10}\n" +
                                $"{"Animals registered:",-20}{nrZooAnimals,-10}\n" +
                                $"{"Carnivore Status:",-20}{CarnivoreStatus,-10}\n";

             return $"{separator}Welcome to {Name}\n{separator}" + base.ToString() +
             formattedAnimals + separator + summaryKPI;
        }
    }

    public class csNordicZoo : csZoo
    {
        public csNordicZoo()
        {
            Name = "Nordic Zoo";
            var rnd = new csSeedGenerator();
            
            for (enAnimalKind kind = enAnimalKind.Moose; kind <= enAnimalKind.Fox; kind++)              // Loopar igenom djur som Moose, Wolf, Deer, Fox,
                                                                                                        // det är som att vi klipper enumen, börjar på index 0 slutar 3.
            {
                int numberOfAnimals = rnd.Next(1, 11);                                                      // Slumpar antalet djur mellan 1 och 10 för varje djursort
                
                for (int i = 0; i < numberOfAnimals; i++)                                                   // Lägger till slumpmässigt antal djur av varje sort
                {
                    var mood = rnd.FromEnum<enAnimalMood>();                                                // Slumpar ett humör för varje djur
                    ListOfAnimal.Add(new csAnimal(rnd) { Kind = kind, Mood = mood });
                    TotalAnimalsRegistered++;
                }
            }
        }

        public int WolfCount                       ///// bool overload for wolf threat?
        {
            get
            {
                int wolfCount = 0;
                
                foreach (var NrAnimals in ListOfAnimal)
                {
                    if (NrAnimals.Kind == enAnimalKind.Wolf)
                        wolfCount++;
                }
                return wolfCount;
            }
        }

        public bool AreCarnivorePresent => WolfCount > 0;
        public override string ToString()
        { 
            string formattedAnimals = $"\n";                                                        // writes output with formatting
            string separator = new string('-', 40) + "\n";
            string CarnivoreStatus = AreCarnivorePresent ? "Carnivore Present" : "No Carnivores";
            
            string summaryKPI =        
                                $"\n{Name} Summary KPI:\n" +
                                $"-------------------------\n" +
                                $"{"Meat eaten per day:",-20}{AfricanMeat,-10}\n" +
                                $"{"Parrot registered:",-20}{ParrotCount,-10}\n" +
                                $"{"Wolves registered:",-20}{WolfCount,-10}\n" +
                                $"{"Animals registered:",-20}{nrZooAnimals,-10}\n" +
                                $"{"Carnivore Status:",-20}{CarnivoreStatus,-10}\n";

             return $"{separator}Welcome to {Name}\n{separator}" + base.ToString() +
             formattedAnimals + separator + summaryKPI;
        }
    }
    public class csBirdZoo : csZoo
    {
        public csBirdZoo()
        {
            Name = "Bird Zoo";
            var rnd = new csSeedGenerator();

            for (enAnimalKind kind = enAnimalKind.Eagle; kind <= enAnimalKind.Parrot; kind++)
            {
                int numberOfAnimals = rnd.Next(5, 11);                                                  // Slumpar mellan 5 och 10 djur
                
                for (int i = 0; i < numberOfAnimals; i++)
                {
                    var mood = rnd.FromEnum<enAnimalMood>();
                    ListOfAnimal.Add(new csAnimal(rnd) { Kind = kind, Mood = mood });
                    TotalAnimalsRegistered++;
                }
            }
        }
        
        public int ParrotCount
        {
            get
            {
                int parrotCount = 0;

                foreach (var NrAnimals in ListOfAnimal)
                {
                    if (NrAnimals.Kind == enAnimalKind.Parrot)
                        parrotCount++;
                }
                return parrotCount;
            }
        }
        public override string ToString()                                                       // writes output with formatting
        {
           string formattedAnimals = $"\n";
            string separator = new string('-', 40) + "\n";
            string CarnivoreStatus = AreCarnivorePresent ? "Carnivore Present" : "No Carnivores";
            
            string summaryKPI =        
                                $"\n{Name} Summary KPI:\n" +
                                $"-------------------------\n" +
                                $"{"Meat eaten per day:",-20}{AfricanMeat,-10}\n" +
                                $"{"Parrot registered:",-20}{ParrotCount,-10}\n" +
                                $"{"Wolves registered:",-20}{WolfCount,-10}\n" +
                                $"{"Animals registered:",-20}{nrZooAnimals,-10}\n" +
                                $"{"Carnivore Status:",-20}{CarnivoreStatus,-10}\n";
                                
             return $"{separator}Welcome to {Name}\n{separator}" + base.ToString() +
             formattedAnimals + separator + summaryKPI;
        }
    }
}

