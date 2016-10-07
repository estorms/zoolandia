
namespace Zoolandia.Animalia.Serepentes
{

    public class Serpentes : Animal
    {
        public string name {get;set;}
        public string diet = "omnivorous";

        public bool legged {get; set;}
        //  public enum height: long {Min = 4L, Max=7L}

        public int mass { get; set; }

        public int length { get; set; }

        public string swim () {
            return $"{this.name} is swimming";
        } 


          public string giveLength (int height) {
            this.length = length;
            return $"{this.name} is {this.length} tall";
        } 
    }


}


