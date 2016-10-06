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
    }

    public class Canidae: Animal {
    
    public bool domesticated {get; set;}

    }

    public class Reptilia: Animal {
    
    public bool legged {get; set;}

    public int avgLength {get; set;}

    }

    public class Primates: Animal {
    
    public double IQ {get; set;}

    }
}