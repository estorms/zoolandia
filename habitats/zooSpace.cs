using System.Collections.Generic;

namespace Zoolandia.ZooSpace
{

    public class Zoo
    {

        public List<string> ZoolandiaAnimals = new List<string>();

        public void addAnimal(string animal)
        {
            ZoolandiaAnimals.Add(animal);
        }

        public string showAnimals()
        {
            string output = "";

            foreach (string animal in ZoolandiaAnimals)
            {
                output += $"\n{animal} has joined Zoolandia!";
            }

            return output;
        }

    }



}