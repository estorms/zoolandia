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

           public string reproduce (int avgOffspring)
        {
           return $"A female has an average of Convert.toInt16({avgOffspring}) in her lifetime.";
        }
    }

    public class Canidae: Animal {
    
    public bool domesticated {get; set;}
    public override string eat(string food) {
        if (food != "vegetables only") {
            return $"This animal eats {food}";
        }
    }

    }

    public class Reptilia: Animal {
    
    public bool legged {get; set;}

    public int avgLength {get; set;}

    }

    public class Primates: Animal {
    
    public double IQ {get; set;}

    }
}