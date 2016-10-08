namespace Zoolandia.GenusClass
{

    public class Genus
    {
        public string genusName { get; set; }

        //Note: You tried to return a string in your constructor below. It didn't work
        public Genus(string genusName) {
            this.genusName = genusName;
        }
    }
}