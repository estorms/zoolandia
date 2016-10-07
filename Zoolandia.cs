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


        public string reproduce(int avgOffspring)
        {
            return $"A female has an average of {avgOffspring} offspring in her lifetime.";
        }
    }

    public class Canidae : Animal
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
