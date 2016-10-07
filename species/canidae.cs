
namespace Zoolandia.Canidae {

public class Canidae : Canis
    {

        public bool domesticated { get; set; }

        public string food {get; set;}

        public override string eat(string food)
        {
            if (food != "plants only")
            {
                this.food = food;
                return $"This animal is an omnivore, and therefore eats {food}";

            }
            else
            {
                return "This animal doesn't eat what you think it does";
            }
        }

        public Canidae()
        {
            this.domesticated = true;
        }

    }
}