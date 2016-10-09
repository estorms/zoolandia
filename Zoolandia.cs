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

            Console.WriteLine("Let's liberate some sentient beings. Who's your pal?");
            Animal Manfred_Mann = new Animal("Manfred Mann");
            Manfred_Mann.species = new Alces ();
            //the following works
           Console.WriteLine(Manfred_Mann.species.speciesDetails());
           //the following does NOT work. speciesDetails is a METHOD on species, which is a PROPERTY on Manfred. Have to burrow into the property itself in order to call its method.

        //    Console.WriteLine(Manfred_Mann.speciesDetails());

            Manfred_Mann.genus = new Genus("Alces");
            Console.WriteLine(Manfred_Mann.animalDetails());
            Animal Barton_Fink = new Animal ("Barton Fink");
            Barton_Fink.species = new Polylepis();
            Barton_Fink.genus = new Genus("Dendroaspis");
           //The following won't work: it tries tries to set the _secretname to the animal name, which is disallowed in the logic in Animal class:
            // Barton_Fink.secretName = "Barton Fink";
            //The following DOES work, because the secret name is not the same as the animal name
            Barton_Fink.secretName = "Bartholomew";
            Console.WriteLine(Barton_Fink.eat("someone's face"));
            Console.WriteLine(Barton_Fink.eat("someone's face", 8));
            // Console.WriteLine(Barton_Fink.species.communicate("Greek"));
            // Console.WriteLine(Manfred_Mann.species.communicate("Urdu"));

            Console.WriteLine(Barton_Fink.species.speciesDetails());

            //OTHER LESSONS: CAN'T CALL A BASE IN A STATIC METHOD, e.g., HERE IN MAIN. Had to do it in the class wherein the overriddent method was defined ... in fact, did it within the same method.

            Console.WriteLine(Manfred_Mann.species.speak("Romanian"));
            if (Console.ReadLine() == "yes") {
                Console.WriteLine("You typed 'yes'");
            }
            else {
                Console.WriteLine("You didn't type 'yes'");
            }
            
        }
    }
}
