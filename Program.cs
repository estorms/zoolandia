using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal firstanimal = new Animal();
            AilurusFulgens redpanda = new AilurusFulgens ();
            redpanda.color = args[0];
            redpanda.averageWeight = Convert.ToInt16(args[1]);

            Console.WriteLine($"{redpanda.averageWeight} averageWeight and {redpanda.color}");
          
        }
    }

}