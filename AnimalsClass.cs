using Zoolandia.SpeciesClass;
using Zoolandia.GenusClass;

namespace Zoolandia.AnimalsClass

{

    public class Animal
    {
        //Public property names, including other classes 
        public string animalName { get; set; }

        public Species species { get; set; }

        public Genus genus { get; set; }
        //Private property names

        private string _secretName = "";

        //Public methods for retrieving private property names

        public string secretName
        {
            get
            {
                return _secretName;
            }

            set
            {
                if (value !=  animalName)
                    _secretName = value;
            }
            
        }
        //Animal constructor method

        public Animal(string animalName)
        {
            this.animalName = animalName;
        }

        //Public methods on animal class
        public string animalDetails()
        {
            return $"{this.animalName} is of the species {this.species} and genus {this.genus}.";
        }

        public string sleep(bool asleep)
        {
            if (asleep == true)
            {
                return $"Scram. {this.animalName} is sleeping.";
            }
            else
            {
                return $"{this.animalName} will graciously receive you.";
            }
        }


        public virtual string eat(string food, int timesPerDay)
        {
            return $"{this.animalName} eats {food} {timesPerDay} a day.";
        }

        public virtual string reproduce(int avgOffspring)
        {

            return $"{this.animalName} has approximately {avgOffspring} in its lifetime.";
        }


    }
}


