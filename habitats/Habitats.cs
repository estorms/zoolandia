using Zoolandia.AnimalsClass;
using System.Collections.Generic;

namespace Zoolandia.Habitats
{

    public class Habitat
    {

        public string name { get; set; }

        public bool openToPublic { get; set; }

        public List<Animal> AllAnimals = new List<Animal>();

        public string showAllAnimals()
        {
            string output = "";

            foreach (Animal animal in AllAnimals)
            {
                output += $"\n{animal.animalName} has joined the global habitat!";
            }

            return output;
        }
    }





}