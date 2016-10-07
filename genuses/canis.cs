
namespace Zoolandia.Animalia.Canis
{

    public class Canis : Animal
    {
        public string name {get;set;}
        public string diet = "omnivorous";

        public int numberOfLegs = 4;
        //  public enum height: long {Min = 4L, Max=7L}

        public bool domesticated { get; set; }

        public int mass { get; set; }

        public int height { get; set; }

        public string swim () {
            return $"{this.name} is swimming";
        } 


          public string giveHeight (int height) {
            this.height = height;
            return $"{this.name} is {this.height} tall";
        } 
    }


}


