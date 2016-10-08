using Zoolandia.SpeciesClass;
using Zoolandia.GenusClass;

namespace Zoolandia.AnimalsClass

{

     public class Animal
    {
        public string animalName { get; set; }

        public Species species { get; set; }

        public Genus genus { get; set; }

        public Animal(string animalName)
        {
            this.animalName = animalName;
        }

        public string animalDetails()
        {
            return $"{this.animalName} is of the species {this.species} and genus {this.genus}.";
        }
    }
}


