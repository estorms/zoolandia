using System;

namespace Zoolandia.Animals 

{

    public class Animal
    {
        public string name { get; set; }
        public int averageHeight {get; set; } 
        public bool hasTail {get; set; } 
        public double tongueLength {get; set; }
        public string sleep ()
        {
           return "Animal is now sleeping";
        }
    }

    public class : Animal {
    
    public string color {get; set;}
    public string loveliness {get;set;}

    }
}