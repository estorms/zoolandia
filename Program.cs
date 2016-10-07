using System;
using Zoolandia.PrimateClass;
using Zoolandia.ReptileClass;
using Zoolandia.Animalia;


namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Primates BobDylan = new Primates("Bob Dylan", 45);

            Console.WriteLine($"Welcome to the WonderDome, {BobDylan.name}. You are {BobDylan.age} years old.");

            Primates JerryGarcia = new Primates("Jerry Garcia", 65);

            Console.WriteLine($"Welcome to the WonderDome, {JerryGarcia.name}. You are {JerryGarcia.age} years old.");

            Primates StephenColbert = new Primates("Stephen Colbert", 85);

            Console.WriteLine($"Welcome to the WonderDome, {StephenColbert.name}. You are {StephenColbert.age} years old.");

            Primates DonaldTrump = new Primates("Donald Trump", 12);

            Console.WriteLine($"Welcome to the WonderDome, {DonaldTrump.name}. You are {DonaldTrump.age} years old.");


            Reptilia cottonMouth = new Reptilia("witch venom", false);
            cottonMouth.eat("eggs");
            Console.WriteLine(cottonMouth.reproduce(5));
            cottonMouth.commonName = "cottonmouth";
            cottonMouth.scientificName = "Agkistrodon piscivorus";
            cottonMouth.endangered = true;

            Console.WriteLine($"This reptile's common name is {cottonMouth.commonName}; its scientific name is {cottonMouth.scientificName}.");

            Console.WriteLine(JerryGarcia.greet());

            Animal noOverloadAnimal = new Animal();
            Console.WriteLine($"Your animal constructed by the method w/o overload has a common name of {noOverloadAnimal.commonName}.");
            Animal overLoadedAnimal = new Animal("Jessup");
            Console.WriteLine($"You animal constructed by the overloaded method is named {overLoadedAnimal.commonName}.");

        }
    }
}