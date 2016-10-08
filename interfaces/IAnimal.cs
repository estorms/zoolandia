namespace Zoolandia.AnimalsInterface {

    interface IAnimal
    {
    string animalDetails();
    string sleep (bool asleep);

    string eat (string food);

    string eat(string food, int timesPerDay);

    string reproduce(int avgOffspring);

    }
}