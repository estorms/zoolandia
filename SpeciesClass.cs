//NOTE: You have to pass in System in order to be able to use Console.WriteLine
// using System;

using Zoolandia.GenusClass;

namespace Zoolandia.SpeciesClass
{

    public class Species
    {
        public string commonName { get; set; }

        public string scientificName { get; set; }

        public bool endangered { get; set; }

        public Genus genus { get; set; }

        public string habitat { get; set; }

        public string speciesDetails()
        {
            if (endangered == true)
            {
                return $"The {this.commonName}'s scientific name is {this.scientificName}. Its natural habitat is {this.habitat}. It IS endangered. Be kind.";
            }

            //Had to explicitly state what to do if endangered == false, even though you would assume that through inference it would work with simply an else {do this, etc.}
            else if (endangered == false)
            {
                return $"The {this.commonName}'s scientific name is {this.scientificName}. Its natural habitat is {this.habitat}. It is not endangered, but you still must be kind.";
            }

            else
            {
                return $"You broke your own code";
            }
        }
        public virtual string speak(string language)
        {
            return $"Most animals speak the language of {language}.";
        }

    }

}