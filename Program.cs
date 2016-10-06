using System;
using Zoolandia.Animalia;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal firstAnimal = new Animal();
            firstAnimal.commonName = args[0];
            firstAnimal.scientificName = args[1];
            if (args[2] == "yes") {
                firstAnimal.endangered = true;
            }
            else 
            {
                firstAnimal.endangered = false;
            }  
                Console.WriteLine($"Your first animal is commonly known as {firstAnimal.commonName} and its scientific name is {firstAnimal.scientificName}. This is its boolean! ${firstAnimal.endangered}");              

        }
    
    }

}