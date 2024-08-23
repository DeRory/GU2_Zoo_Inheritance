using System;
using Seido.Utilities.SeedGenerator;

namespace GU1_Zoo
{
	public enum enAnimalKind { Moose, Wolf, Deer, Fox, Aligator, Elephant, Lion, Monkey, Eagle, Hawk, Owl, Parrot}
	public enum enAnimalMood { Happy, Sleepy, Sad, Hungry, Lazy, Quick, Slow }
	public class csAnimal
	{
		public enAnimalKind Kind { get; set; }
		public enAnimalMood Mood { get; set; }
		public int Age { get; set; }
		public string Name { get; set; }

		public override string ToString() => $"{Name} the {Mood} {Age}yr {Kind}";
       

        public csAnimal(csSeedGenerator _seeder)
		{
			Kind = _seeder.FromEnum<enAnimalKind>();
			Mood = _seeder.FromEnum<enAnimalMood>();
			Age = _seeder.Next(0, 10);
			Name = _seeder.PetName;
		}
        public csAnimal(csAnimal org)
        {
			Kind = org.Kind;
			Mood = org.Mood;
			Age = org.Age;
            Name = org.Name;
        }
    }
}

