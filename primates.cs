using Zoolandia.Animalia;

namespace Zoolandia.PrimateClass
{
public class Primates : Animal
    {

        public double IQ { get; set; }
        public string name {get; set;}

        public int age {get; set;}

        public Primates(string name, int age)
        {
            this.IQ = 1.2;
            this.name = name;
            this.age = age;
        }

        public override string eat(string food)
        {
            if (food == "Hostess Fruit Pie")
            {
                return this.food = food;
            }
            else
            {
                return "This animal doesn't eat what you think it does";
            }
        }
           public override string greet() {
            return $"{base.greet()}. You have an IQ of {this.IQ}.";
        }
    }
}