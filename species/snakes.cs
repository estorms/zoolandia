
namespace Zoolandia.Animalia.Serpentes.Snakes {
public class Snakes : Serpents
    {
        public string name {get;set;}


        public string poison {get; set; }

        public int avgLength { get; set; }

        public Snakes(string name, string poison, int avgLength)
        {
            this.name = name;
            this.poison = poison;
            this.avgLength = avgLength;
        }

        public override string eat(string food)
        {
           return $"{this.name} eats {food} and {food} only";
        }

        public string eat (string food, int timesPerDay) {
            return $"{this.name} eats {food} {timesPerDay} times per day.";
        } 
        
        //must create the constructor function within the class itself
        //had to add an else to the if statement in order to account for the string return and avoid error message stating that not all paths returned a function
    }
}