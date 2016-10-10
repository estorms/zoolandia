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

//cool things to do: cycle through each animal, determine its habitat based on species property

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //initiate Program

            Console.WriteLine("Let's liberate some sentient beings! Who would you like to release from the zoo?");

            Habitat appHabitat = new Habitat();
            //create animals


            Animal Manfred_Mann = new Animal("Manfred Mann");
            Manfred_Mann.species = new Alces();
            Manfred_Mann.species.genus = new Genus("Alces");
            //below is NOT dry
            // appHabitat.addToAllAnimals(Manfred_Mann);
            //add animals directly here, instead of via method defined in habitat class: this IS dry
            appHabitat.AllAnimals.Add(Manfred_Mann);
            
            // Console.WriteLine(Manfred_Mann.species.speciesDetails());

            Animal Martha = new Animal("Martha");
            Martha.species = new Murinus();
            Martha.species.genus = new Genus("Eunectes");
            appHabitat.AllAnimals.Add(Martha);            
            
            // Console.WriteLine(Martha.species.speciesDetails());

            Animal Barton_Fink = new Animal("Barton Fink");
            Barton_Fink.species = new Polylepis();
            Barton_Fink.species.genus = new Genus("Dendroaspis");
            appHabitat.AllAnimals.Add(Barton_Fink);            
            
            // Console.WriteLine(Barton_Fink.species.speciesDetails());

            Animal Jeffrey = new Animal("Jeffrey");
            Jeffrey.species = new Geoffrensis();
            Jeffrey.species.genus = new Genus("Inus");
            appHabitat.AllAnimals.Add(Barton_Fink);            
            
            // Console.WriteLine(Jeffrey.species.speciesDetails());

            Animal Mr_Bipps = new Animal("Mr. Bipps");
            Mr_Bipps.species = new Suricatta();
            Mr_Bipps.species.genus = new Genus("Suricata");
            appHabitat.AllAnimals.Add(Mr_Bipps);            
            
            // Console.WriteLine(Mr_Bipps.species.speciesDetails());

            Animal Sally = new Animal("Sally");
            Sally.species = new Sirtalis();
            Sally.species.genus = new Genus("Thamnophis");
            appHabitat.AllAnimals.Add(Sally);            
            
            // Console.WriteLine(Sally.species.speciesDetails());

            Animal PatPat = new Animal("PatPat");
            PatPat.species = new Pacifica();
            PatPat.species.genus = new Genus("Gavia");
            appHabitat.AllAnimals.Add(PatPat);
            
            // Console.WriteLine(PatPat.species.speciesDetails());

            Animal Terry = new Animal("Terry");
            Terry.species = new Tetradactyla();
            Terry.species.genus = new Genus("Phataginus");
            appHabitat.AllAnimals.Add(Terry);            
            // Console.WriteLine(Terry.species.speciesDetails());

            Animal Viraj = new Animal("Viraj");
            Viraj.species = new Variegatus();
            Viraj.species.genus = new Genus("Bradypus");
            appHabitat.AllAnimals.Add(Viraj);            
            
            // Console.WriteLine(Viraj.species.speciesDetails());
            //the following works

            // Console.WriteLine(Manfred_Mann.species.speciesDetails());
            //the following does NOT work. speciesDetails is a METHOD on species, which is a PROPERTY on Manfred. Have to burrow into the property itself in order to call its method.

            //    Console.WriteLine(Manfred_Mann.speciesDetails());

            // Console.WriteLine(Manfred_Mann.animalDetails());
            // The following won't work: it tries tries to set the _secretname to the animal name, which is disallowed in the logic in Animal class:
            // Barton_Fink.secretName = "Barton Fink";
            // The following DOES work, because the secret name is not the same as the animal name
            Barton_Fink.secretName = "Bartholomew";
            Console.WriteLine(Barton_Fink.eat("someone's face"));
            Console.WriteLine(Barton_Fink.eat("someone's face", 8));
            Console.WriteLine(Barton_Fink.species.speciesDetails());

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
            AmazonianRainforestHabitat.AllAnimals.Add(Martha);
            AmazonianRainforestHabitat.AllAnimals.Add(Jeffrey);
            AmazonianRainforestHabitat.AllAnimals.Add(Viraj);

            BorealForestHabitat.AllAnimals.Add(Manfred_Mann);
            BorealForestHabitat.AllAnimals.Add(PatPat);
            BorealForestHabitat.AllAnimals.Add(Sally);

            SouthAfricanHabitat.AllAnimals.Add(Barton_Fink);
            SouthAfricanHabitat.AllAnimals.Add(Mr_Bipps);
            SouthAfricanHabitat.AllAnimals.Add(Terry);

            //show user habitats and their animals

            // Console.WriteLine(SouthAfricanHabitat.showSouthAfricanAnimals());
            // Console.WriteLine(BorealForestHabitat.showBorealForestAnimals());
            // Console.WriteLine(AmazonianRainforestHabitat.showAmazonianRainforestAnimals());



            Console.WriteLine("Make a new animal! Enter its name, species, and secret name!");
            // Animal myAnimal = new Animal(args[0]);
            // Console.WriteLine(myAnimal.animalName);
            string userinput = Console.ReadLine();
            string userAnimalName = userinput.Split(new Char[] { ' ' })[0];
            string userSpeciesChoice = userinput.Split(new Char[] { ' ' })[1];
            string userSecretName = userinput.Split(new Char[] { ' ' })[2];

            //following won't work, still need to fully investigate why, has to do with how Console.WriteLine works, expects what happens after comma to be an argument:

            // Console.WriteLine(userAnimalName, userSecretName)

            // will work
            Console.WriteLine($"{userAnimalName} {userSpeciesChoice} {userSecretName}");
            Animal userAnimal = new Animal(userAnimalName);
            string userAnimalSpeciesCommonName = null;
            
            foreach (Animal animal in appHabitat.AllAnimals) {
                if (animal.species.commonName == userSpeciesChoice) {
                    Console.WriteLine("match!");
                    userAnimalSpeciesCommonName = userSpeciesChoice;
                    userAnimal.species = new Pacifica();
                    
                }
            }
            // Animal userAnimal = new Animal("userAnimalName");
        }

        // private static Animal[] GetAllAnimals(Animal[] allAnimals)
        // {
        //     return allAnimals;
        // }
    }
}
