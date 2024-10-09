using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using Seido.Utilities.SeedGenerator;

namespace GU1_Zoo
{
    public class csZoo
    {
        public List<csAnimal> ListOfAnimal { get; set; } = new List<csAnimal>();
        public string Name { get; set; }

        public int ParrotCount {get; set;} = default;

        public override string ToString()
        {
            string sRet = "";
            foreach (var item in ListOfAnimal)
            {
                sRet += $"\n{item}";
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
            }
        }
        public csZoo()
        {
            
        }

        public virtual string Question => $"Hello???";

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
                }
            }
        }

        public int AfricanMeat //En metod med typen int som parameter och räknar totala meat konsumtion
        {
            get
            {
                int totalMeat = 0; //Vi börjar med att säga att totala konsumtionen ligger på 0kg. 
                foreach (var nrAnimals in ListOfAnimal) //För varje number of animal i ListOfAnimal och om djurens kind är samma sak som Aligator, plussa på med 10, samma för lion dock 5.
                {
                    if (nrAnimals.Kind == enAnimalKind.Aligator)
                        totalMeat += 10;
                    else if (nrAnimals.Kind == enAnimalKind.Lion)
                        totalMeat += 5;
                }
                return totalMeat; //Här returnerar vi det totala värdet
            }
        }

        // public override string Question => $"The total meat eaten {AfricanMeat}";




        public override string ToString()
        {
            return $"Welcome to {Name}\n" + base.ToString() + $"\nTotal meat eaten per day is: {AfricanMeat}kg";
            // Parrot Count:{parrotCount}
        }
    }

    public class csNordicZoo : csZoo
    {
        public csNordicZoo()
        {
            Name = "Nordic Zoo";
            var rnd = new csSeedGenerator();

            // Loopar igenom djur som Moose, Wolf, Deer, Fox, det är som att vi klipper enumen, börjar på index 0 och slutar på index 3.
            for (enAnimalKind kind = enAnimalKind.Moose; kind <= enAnimalKind.Fox; kind++)
            {
                // Slumpar antalet djur mellan 1 och 10 för varje djursort
                int numberOfAnimals = rnd.Next(1, 11);

                // Lägger till slumpmässigt antal djur av varje sort
                for (int i = 0; i < numberOfAnimals; i++)
                {
                    var mood = rnd.FromEnum<enAnimalMood>(); // Slumpar ett humör för varje djur
                    ListOfAnimal.Add(new csAnimal(rnd) { Kind = kind, Mood = mood });
                }
            }
        }

        public int WolfCount
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

        

        public override string ToString()
        {
            return $"\nWelcome to {Name}!\n" + base.ToString() + $"\nTotal number of Wolves is: {WolfCount}";
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
                int numberOfAnimals = rnd.Next(5, 11); // Slumpar mellan 5 och 10 djur

                for (int i = 0; i < numberOfAnimals; i++)
                {
                    var mood = rnd.FromEnum<enAnimalMood>();
                    ListOfAnimal.Add(new csAnimal(rnd) { Kind = kind, Mood = mood });
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


        public override string ToString()
        {
            return $"\nWelcome to {Name}\n" + base.ToString() + $"\nTotal number of Parrots is: {ParrotCount}";
        }
    }
}

