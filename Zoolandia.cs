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
using Zoolandia.AmazonianRainforest;
using Zoolandia.SouthAfrica;
using Zoolandia.BorealForest;
using Zoolandia.Habitats;


namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //initiate Program

            Console.WriteLine("Let's liberate some sentient beings. Who's your pal?");

            //create animals

            Animal Manfred_Mann = new Animal("Manfred Mann");
            Manfred_Mann.species = new Alces();
            Manfred_Mann.genus = new Genus("Alces");
            Console.WriteLine(Manfred_Mann.species.speciesDetails());

            Animal Martha = new Animal("Martha");
            Martha.species = new Murinus();
            Martha.genus = new Genus("Eunectes");
            Console.WriteLine(Martha.species.speciesDetails());

            Animal Barton_Fink = new Animal("Barton Fink");
            Barton_Fink.species = new Polylepis();
            Barton_Fink.genus = new Genus("Dendroaspis");
            Console.WriteLine(Barton_Fink.species.speciesDetails());

            Animal Jeffrey = new Animal("Jeffrey");
            Jeffrey.species = new Geoffrensis();
            Jeffrey.genus = new Genus("Inus");
            Console.WriteLine(Jeffrey.species.speciesDetails());

            Animal Mr_Bipps = new Animal("Mr. Bipps");
            Mr_Bipps.species = new Suricatta();
            Mr_Bipps.genus = new Genus("Suricata");
            Console.WriteLine(Mr_Bipps.species.speciesDetails());

            Animal Sally = new Animal("Sally");
            Sally.species = new Sirtalis();
            Sally.genus = new Genus("Thamnophis");
            Console.WriteLine(Sally.species.speciesDetails());

            Animal PatPat = new Animal("PatPat");
            PatPat.species = new Pacifica();
            PatPat.genus = new Genus("Gavia");
            Console.WriteLine(PatPat.species.speciesDetails());

            Animal Terry = new Animal("Terry");
            Terry.species = new Tetradactyla();
            Terry.genus = new Genus("Phataginus");
            Console.WriteLine(Terry.species.speciesDetails());

            Animal Viraj = new Animal("Viraj");
            Viraj.species = new Variegatus();
            Viraj.genus = new Genus("Bradypus");
            Console.WriteLine(Viraj.species.speciesDetails());
            //the following works
            Console.WriteLine(Manfred_Mann.species.speciesDetails());
            //the following does NOT work. speciesDetails is a METHOD on species, which is a PROPERTY on Manfred. Have to burrow into the property itself in order to call its method.

            //    Console.WriteLine(Manfred_Mann.speciesDetails());

            Console.WriteLine(Manfred_Mann.animalDetails());
            //The following won't work: it tries tries to set the _secretname to the animal name, which is disallowed in the logic in Animal class:
            // Barton_Fink.secretName = "Barton Fink";
            //The following DOES work, because the secret name is not the same as the animal name
            Barton_Fink.secretName = "Bartholomew";
            Console.WriteLine(Barton_Fink.eat("someone's face"));
            Console.WriteLine(Barton_Fink.eat("someone's face", 8));
            Console.WriteLine(Barton_Fink.species.speciesDetails());

            Console.WriteLine(Jeffrey.species.commonName);
            //OTHER LESSONS: CAN'T CALL A BASE IN A STATIC METHOD, e.g., HERE IN MAIN. Had to do it in the class wherein the overridden method was defined ... in fact, did it within the same method.

            Console.WriteLine(Manfred_Mann.species.speak("Romanian"));
            // Console.WriteLine("Give Manfred Mann a secret name! Just remember, it must be different from his real name.");
            // Manfred_Mann.secretName = Console.ReadLine();
            // Console.WriteLine($"Manfred Mann's secret name has been set to {Manfred_Mann.secretName}");

            //create habitats
            BorealForestHabitat BorealForestHabitat = new BorealForestHabitat();
            AmazonianRainforestHabitat AmazonianRainforestHabitat = new AmazonianRainforestHabitat();
            SouthAfricanHabitat SouthAfricanHabitat = new SouthAfricanHabitat();

            //add animals to habitats
            AmazonianRainforestHabitat.addtoAmazonianRainforest(Martha);
            AmazonianRainforestHabitat.addtoAmazonianRainforest(Jeffrey);
            AmazonianRainforestHabitat.addtoAmazonianRainforest(Viraj);

            BorealForestHabitat.addToBorealForest(Manfred_Mann);
            BorealForestHabitat.addToBorealForest(PatPat);
            BorealForestHabitat.addToBorealForest(Sally);

            SouthAfricanHabitat.addToSouthAfricanHabitat(Barton_Fink);
            SouthAfricanHabitat.addToSouthAfricanHabitat(Mr_Bipps);
            SouthAfricanHabitat.addToSouthAfricanHabitat(Terry);

            //show user habitats and their animals

            Console.WriteLine(SouthAfricanHabitat.showSouthAfricanAnimals());
            Console.WriteLine(BorealForestHabitat.showBorealForestAnimals());
            Console.WriteLine(AmazonianRainforestHabitat.showAmazonianRainforestAnimals());


            // Animal myAnimal = new Animal(args[0]);
            // Console.WriteLine(myAnimal.animalName);

        }
    }
}
