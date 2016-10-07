using System;

namespace Zoolandia.Animalia

{

    public class Animal
    {
        public string commonName { get; set; }
        public string scientificName { get; set; }
        public bool endangered { get; set; }

        public string food {get; set;}

        public void sleep()
        {
            Console.Write("Animal is now sleeping");
        }

        public virtual string eat(string food)
        {
            this.food = food;
            return $"This animal easts {food}";
        }

        public virtual string greet() {
            return $"Welcome, {this.commonName}";
        }


        public Animal()
        {
            this.commonName = "animal";
            
        }

        public Animal (string name) {
            this.commonName = name;
        }

        public string reproduce(int avgOffspring)
        {
            return $"A female has an average of {avgOffspring} offspring in her lifetime.";
        }
    }    
}
