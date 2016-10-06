using System;

namespace Zoolandia.Animals 

{

    public class Animal
    {
        public string name { get; set; }
        public int averageWeight {get; set; } 
        public bool livesWithLiz {get; set; } 
        public double tongueLength {get; set;}
        public string sleep ()
        {
           return "Animal is now sleeping";
        }
    }
}