using Zoolandia.SpeciesClass;
using Zoolandia.FatalToHumansInterface;

namespace Zoolandia.Animals.Polylepis
{

    public class Polylepis : Species, IFatalToHumans
    {

         public string killsBy { get; set; }

        public Polylepis()
        {
            this.commonName = "black mamba";
            this.scientificName = "Polylepsis";
            this.endangered = false;
            this.habitat = "South Africa";
            this.killsBy = "poison";
//genus: dendroaspis
        }

    }
// 
}

