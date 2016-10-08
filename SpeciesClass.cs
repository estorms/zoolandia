namespace Zoolandia.SpeciesClass
{

    public class Species
    {
        public string commonName { get; set; }

        public string scientificName { get; set; }

        public  bool endangered { get; set; }

        public string habitat {get; set ;}

        public string speciesDetails () {
            return $"The {this.commonName}'s scientific name is {this.scientificName}. Its natural habitat is {this.habitat}.";
        }

    }

}