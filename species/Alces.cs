// using System;
using Zoolandia.SpeciesClass;
using Zoolandia.FatalToHumansInterface;

namespace Zoolandia.Animals.Alces
{

    public class Alces : Species, IFatalToHumans
    {

        public string killsBy { get; set; }

        public Alces()
        {
            this.commonName = "moose";
            this.scientificName = "Alces";
            this.endangered = false;
            this.habitat = "Boreal Forest";
            this.killsBy = "goring";
            //genus: Alces
        }
        public override string speak(string language)
        {
            return $"The {this.commonName} speaks the language of {language}. {base.speak("Urdu")}";
        }
    }
    // 
}
