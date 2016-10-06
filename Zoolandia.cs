using System;

namespace Zoolandia.Animalia 

{

    public class Animal
    {
        public string commonName { get; set; }
        public string scientificName {get; set; } 
        public bool endangered {get; set; } 

        public string sleep ()
        {
           return "Animal is now sleeping";
        }

        public virtual void eat (string food)
        {
           Console.Write($"Animal is now eating {food}");
        }


            public Animal () {
                this.commonName = "animal"; 
            }


           public string reproduce (int avgOffspring)
        {
           return $"A female has an average of {avgOffspring} offspring in her lifetime.";
        }
    }

    public class Canidae: Animal {
    
    public bool domesticated {get; set;}
    public override void eat(string food) {
        if (food != "vegetables only") {
            Console.WriteLine( $"This animal eats {food}");
        }
    }

    public Canidae (){
        this.domesticated = true;
    }

    }

    public class Reptilia: Animal {
    
    public bool legged {get; set;}

    public int avgLength {get; set;}

    public Reptilia () {
        this.legged = true;
    }

//must create the constructor function within the class itself
    }

   

    public class Primates: Animal {
    
    public double IQ {get; set;}

    public Primates () {
        this.IQ = 1.2;
    }
    
    }
}