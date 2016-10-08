//NOTE: You have to pass in System in order to be able to use Console.WriteLine
using System;
namespace Zoolandia.SpeciesClass
{

    public class Species
    {
        public string commonName { get; set; }

        public string scientificName { get; set; }

        public bool endangered { get; set; }

        public string habitat { get; set; }

        public string speciesDetails()
        {
            return $"The {this.commonName}'s scientific name is {this.scientificName}. Its natural habitat is {this.habitat}.";
        }
        public virtual string speak(string language)
        {
            return $"Most animals speak the language of {language}.";
        }

    }

}