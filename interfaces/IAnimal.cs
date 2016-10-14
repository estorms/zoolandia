namespace Zoolandia.AnimalsInterface {

//All methods/properties in interface must be in implementing class, but implementing class can have additional properties/methods
//Interfaces may only dictate properties/and methods each using class will implement--not define/declare those prop values or method behaviors
    interface IAnimal
    {
    string animalDetails();
    string sleep (bool asleep);

    string eat (string food);

    string eat(string food, int timesPerDay);

    string reproduce(int avgOffspring);

    }
}