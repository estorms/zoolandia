using System;
using Zoolandia.AnimalsClass;
using Zoolandia.Animals.Alces;
using Zoolandia.Animals.Geoffrensis;
using Zoolandia.Animals.Murinus;
using Zoolandia.Animals.Pacifica;
using Zoolandia.Animals.Polylepis;
using Zoolandia.Animals.Sirtalis;
using Zoolandia.Animals.Suricatta;
using Zoolandia.Animals.Tetradactyla;
using Zoolandia.Animals.Variegatus;
using Zoolandia.GenusClass;
using Zoolandia.SpeciesClass;


namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Animal Manfred_Mann = new Animal("Manfred Mann");
            Manfred_Mann.species = new Alces ();
            //the following works
           Console.WriteLine(Manfred_Mann.species.speciesDetails());
           //the following does NOT work. speciesDetails is a METHOD on species, which is a PROPERTY on Manfred. Have to burrow into the property itself in order to call its method.

        //    Console.WriteLine(Manfred_Mann.speciesDetails());

            Manfred_Mann.genus = new
           
           
        }
    }
}
