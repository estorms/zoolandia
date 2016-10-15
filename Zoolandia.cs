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
using Zoolandia.SpeciesClass;

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

            //use method on species class

            Console.WriteLine(Manfred_Mann.species.speciesDetails());

            Animal Martha = new Animal("Martha");
            Martha.species = new Murinus();
            Martha.species.genus = new Genus("Eunectes");
            appHabitat.AllAnimals.Add(Martha);

            Console.WriteLine(Martha.species.speciesDetails());
            Animal Barton_Fink = new Animal("Barton Fink");
            Barton_Fink.species = new Polylepis();
            Barton_Fink.species.genus = new Genus("Dendroaspis");
            appHabitat.AllAnimals.Add(Barton_Fink);

            Console.WriteLine(Barton_Fink.species.speciesDetails());

            Animal Jeffrey = new Animal("Jeffrey");
            Jeffrey.species = new Geoffrensis();
            Jeffrey.species.genus = new Genus("Inus");
            appHabitat.AllAnimals.Add(Barton_Fink);

            Console.WriteLine(Jeffrey.species.speciesDetails());

            Animal Mr_Bipps = new Animal("Mr. Bipps");
            Mr_Bipps.species = new Suricatta();
            Mr_Bipps.species.genus = new Genus("Suricata");
            appHabitat.AllAnimals.Add(Mr_Bipps);

            Console.WriteLine(Mr_Bipps.species.speciesDetails());

            Animal Sally = new Animal("Sally");
            Sally.species = new Sirtalis();
            Sally.species.genus = new Genus("Thamnophis");
            appHabitat.AllAnimals.Add(Sally);

            Console.WriteLine(Sally.species.speciesDetails());

            Animal PatPat = new Animal("PatPat");
            PatPat.species = new Pacifica();
            PatPat.species.genus = new Genus("Gavia");
            appHabitat.AllAnimals.Add(PatPat);

            Console.WriteLine(PatPat.species.speciesDetails());

            Animal Terry = new Animal("Terry");
            Terry.species = new Tetradactyla();
            Terry.species.genus = new Genus("Phataginus");
            appHabitat.AllAnimals.Add(Terry);
            Console.WriteLine(Terry.species.speciesDetails());

            Animal Viraj = new Animal("Viraj");
            Viraj.species = new Variegatus();
            Viraj.species.genus = new Genus("Bradypus");
            appHabitat.AllAnimals.Add(Viraj);

            Console.WriteLine(Viraj.species.speciesDetails());
            //the following works

            // Console.WriteLine(Manfred_Mann.species.speciesDetails());

            //the following does NOT work. speciesDetails is a METHOD on species, which is a PROPERTY on Manfred. Have to burrow into the property itself in order to call its method.

            //    Console.WriteLine(Manfred_Mann.speciesDetails());

            // Console.WriteLine(Manfred_Mann.animalDetails());
            // The following won't work: it tries tries to set the _secretname to the animal name, which is disallowed in the logic in Animal class:
            // Barton_Fink.secretName = "Barton Fink";
            // The following DOES work, because the secret name is not the same as the animal name
            Barton_Fink.secretName = "Bartholomew";

            //use all methods on animal class, including overridden methods

            Console.WriteLine(Barton_Fink.eat("someone's face"));
            Console.WriteLine(Barton_Fink.eat("someone's face", 8));
            Console.WriteLine(Barton_Fink.species.speciesDetails());
            Console.WriteLine(Barton_Fink.sleep(true));
            Console.WriteLine(Barton_Fink.reproduce(17));

            //OTHER LESSONS: CAN'T CALL A BASE IN A STATIC METHOD, e.g., HERE IN MAIN. Had to do it in the class wherein the overridden method was defined ... in fact, did it within the same method.

            //use virtual method on species class that is overridden in Alces class, which inherits from species. This method uses both the base method and the ovverriden method

            Console.WriteLine(Manfred_Mann.species.speak("Romanian"));


            //create habitats
            BorealForestHabitat BorealForestHabitat = new BorealForestHabitat("Boreal Forest");
            AmazonianRainforestHabitat AmazonianRainforestHabitat = new AmazonianRainforestHabitat("Amazonian Rainforest");
            SouthAfricanHabitat SouthAfricanHabitat = new SouthAfricanHabitat("South African");

            //add animals to habitats & show user each animal in habitat
            AmazonianRainforestHabitat.AllAnimals.Add(Martha);
            AmazonianRainforestHabitat.AllAnimals.Add(Jeffrey);
            AmazonianRainforestHabitat.AllAnimals.Add(Viraj);
            Console.WriteLine(AmazonianRainforestHabitat.showAllAnimals(AmazonianRainforestHabitat.name));

            BorealForestHabitat.AllAnimals.Add(Manfred_Mann);
            BorealForestHabitat.AllAnimals.Add(PatPat);
            BorealForestHabitat.AllAnimals.Add(Sally);
            Console.WriteLine(BorealForestHabitat.showAllAnimals(BorealForestHabitat.name));


            SouthAfricanHabitat.AllAnimals.Add(Barton_Fink);
            SouthAfricanHabitat.AllAnimals.Add(Mr_Bipps);
            SouthAfricanHabitat.AllAnimals.Add(Terry);
            Console.WriteLine(SouthAfricanHabitat.showAllAnimals(SouthAfricanHabitat.name));

            //prompt user to make a new animal of his or her choosing
            Console.WriteLine("Make a new animal! Enter its name, species, and secret name!");
            string userinput = Console.ReadLine();
            string userAnimalName = userinput.Split(new Char[] { ' ' })[0];
            string userSpeciesChoice = userinput.Split(new Char[] { ' ' })[1];
            string userSecretName = userinput.Split(new Char[] { ' ' })[2];
            
            Animal userAnimal = new Animal(userAnimalName);
            Console.WriteLine(userAnimal.animalName);
            userAnimal.secretName = userSecretName;
            Console.WriteLine(userAnimal.secretName);

            
            int printMe = 34;
            ///LOOK AT THE SYNTAX DIFFERENCE BETWEEN THE BELOW METHODS OF PASSING IN DATA: ONE IS INTERPOLATION, THE OTHER ARGUMENT INJECTION!!!!
            Console.WriteLine("{0} {1} {2}", userSecretName, printMe, Barton_Fink.species.endangered);
            Console.WriteLine($"{userAnimalName} {userSpeciesChoice} {userSecretName}");


            foreach (Animal animal in appHabitat.AllAnimals)
            {
                //extract the scientific name as well as the common name and use that to instantiate a new animal of the chosen species
                if (animal.species.commonName == userSpeciesChoice)
                {
                    Console.WriteLine("match found!");
                    //make new instance of species using object initializer pattern to apply user input
                    Species userSpecies = new Species {
                    scientificName = animal.species.scientificName,
                    commonName = userSpeciesChoice,
                    endangered = animal.species.endangered,
                    habitat = animal.species.habitat

                };
                    // userAnimal.species = userSpecies;


                }
                // Console.WriteLine($"You've released {userAnimal.animalName}, secretly named {userAnimal.secretName} and known scientifically as {userAnimal.species.scientificName}, from the zoo!");
            }
        }
    }
}
