using System;
using Zoolandia.AnimalsClass;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //mongoose
            Animal Manson = new Animal("Manson");
            Manson.species = new Species("meerkat", "Suricata suricatta");
            Manson.genus = new Genus ("Suricata");
        }
    }
}
