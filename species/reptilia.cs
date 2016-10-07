using Zoolandia.Animalia;

namespace Zoolandia.ReptileClass {
public class Reptilia : Animal
    {

        public bool legged { get; set; }

        public string poison {get; set; }

        public int avgLength { get; set; }

        public Reptilia(string poison, bool legged)
        {
            this.legged = legged;
            this.poison = poison;
        }

        public override string eat(string food)
        {
            if (food == "eggs")
            {
                return $"This animal eats {food}";
            }
            else
            {
                return $"This animal eats {food}";
            }
        }
        //must create the constructor function within the class itself
        //had to add an else to the if statement in order to account for the string return and avoid error message stating that not all paths returned a function
    }
}