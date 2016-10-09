using Zoolandia.SpeciesClass;
using Zoolandia.FatalToHumansInterface;

namespace Zoolandia.Animals.Murinus
{

    public class Murinus : Species, IFatalToHumans
    {

        public string killsBy { get; set; }
        public Murinus()
        {
            this.commonName = "Green anaconda";
            this.scientificName = "Murinus";
            this.endangered = false;
            this.habitat = "Amazonian Rainforest";
            this.killsBy = "strangulation";
        }
        public override string speak(string language)
        {
            return $"The {this.commonName} speaks the language of {language}. {base.speak("Urdu")}";
        }
    }
    // 
}

