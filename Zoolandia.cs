namespace Zoolandia.Taxonomy

{

    public class Animal
    {
        public string animalName { get; set; }

        public Species species { get; set; }

        public Genus genus { get; set; }

        public Animal(string animalName)
        {
            this.animalName = animalName;
        }

        public string animalDetails () {
            return $"{this.animalName} is of the species {this.species} and genus {this.genus}.";
            }
        }
    }


    public class Species
    {
        public string commonName { get; set; }

         public string scientificName { get; set; }

        public Species(string commonName, string scientificName)
        {
            this.commonName = commonName;
            this.scientificName = scientificName;

        }
    }

    public class Genus
    {
        public string genusName { get; set; }

        public Genus(string genusName)
        {
            this.genusName = genusName;
        }
    }

}
