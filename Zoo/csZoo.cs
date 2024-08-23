using System;
using Seido.Utilities.SeedGenerator;

namespace GU1_Zoo
{
    public class csZoo
    {
        public List<csAnimal> ListOfAnimal { get; set; } = new List<csAnimal>();
        public string Name { get; set; }

        public override string ToString()
        {
            string sRet = $"\n{Name}:";
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
            Name = "Reference Zoo";
            var rnd = new csSeedGenerator();

            /*
            #region every kind and mood using foreach
            var kinds = typeof(enAnimalKind).GetEnumValues();
            foreach (enAnimalKind kind in kinds)
            {
                var moods = typeof(enAnimalMood).GetEnumValues();
                foreach (enAnimalMood mood in moods)
                {
                    ListOfAnimal.Add(new csAnimal(rnd) { Kind = kind, Mood = mood });
                }
            }
            #endregion
            */
            #region every kind of African Animals
            for (enAnimalKind  kind = enAnimalKind.Aligator; kind <= enAnimalKind.Monkey; kind++)
            {
                var moods = typeof(enAnimalMood).GetEnumValues();
                foreach (enAnimalMood mood in moods)
                {
                    ListOfAnimal.Add(new csAnimal(rnd) { Kind = kind, Mood = mood });
                }
            }
            #endregion

        }
    }
}

