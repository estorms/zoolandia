using System;
using Zoolandia.SpeciesClass;

namespace Zoolandia.Animals.Alces
{

    public class Alces : Species
    {

        public Alces()
        {
            this.commonName = "moose";
            this.scientificName = "Alces";
            this.endangered = false;
            this.habitat = "Boreal Forest";
            //genus: Alces
        }
         public override string speak(string language)
        {
            return $"The {this.commonName} speaks the language of {language}. {base.speak("Urdu")}";
        }
    }
    // 
}
