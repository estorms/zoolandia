using System;
using Zoolandia.Animalia;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Animal firstAnimal = new Animal();
            // firstAnimal.commonName = args[0];
            // firstAnimal.scientificName = args[1];
            // if (args[2] == "yes") {
            //     firstAnimal.endangered = true;
            // }
            // else 
            // {
            //     firstAnimal.endangered = false;
            // }  
                
                Canidae mycanidae = new Canidae();
                mycanidae.commonName = "jim";

                Console.WriteLine("Your first animal is commonly known as {0}", mycanidae.commonName);   

                Animal myAnimal = new Animal();
                Console.WriteLine(myAnimal.commonName); 
                Console.WriteLine(myAnimal.reproduce(7));          
        
        }
    }
}