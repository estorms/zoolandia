using System.Collections.Generic;
using Zoolandia.AnimalsClass;

namespace Zoolandia.ZooSpace
{

    public class Zoo
    {

        public List<Animal> ZoolandiaAnimals = new List<Animal>();

        public void addAnimal(Animal animal)
        {
            ZoolandiaAnimals.(animal);
        }

        public string showAnimals()
        {
            string output = "";

            foreach (Animal animal in ZoolandiaAnimals)
            {
                output += $"\n{animal.animalName} has joined Zoolandia!";
            }

            return output;
        }

    }



}