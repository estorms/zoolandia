using Zoolandia.SpeciesClass;

namespace Zoolandia.Animals.Geoffrensis
{

    public class Geoffrensis : Species
    {

        public Geoffrensis()
        {
            this.commonName = "River dolphin";
            this.scientificName = "Geoffrensis";
            this.endangered = false;
            this.habitat = "Amazonian Rainforest";
            //genus: Inus
        }
        public override string speak(string language)
        {
            return $"The {this.commonName} speaks the language of {language}. {base.speak("Urdu")}";
        }
    }
    // 
}

