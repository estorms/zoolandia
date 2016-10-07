using System;
using Zoolandia.Taxonomy;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal Manson = new Animal("Manson");
            Manson.species = new Species("meerkat", "Suricata suricatta");
        }
    }
}
