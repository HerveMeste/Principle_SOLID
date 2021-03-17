using System;
using System.Collections.Generic;

namespace OpenClosedPrincipleViolation
{
    public class Program
    {
        public static void Main()
        {
            Factory factory = new Factory();

            IEnumerable<Craftable> craftables = new List<Craftable>
            {
                new Wood(),
                new Metal()
            };

            Production production = factory.Craft(craftables);

            Console.WriteLine(production);
            /*           Factory factory = new Factory();

                       List<Wood> woodBlocks = new List<Wood>
                       {
                           new Wood(),
                           new Wood()
                       };

                       List<Metal> metalBlocks = new List<Metal>
                       {
                           new Metal(),
                           new Metal()
                       };
                       List<Production> manyProductions = new List<Production>
                       {
                           factory.CraftWood(woodBlocks),
                           factory.CraftMetal(metalBlocks)
                       };

                       foreach (Production production in manyProductions)
                       {
                           Console.WriteLine(production);
                       }*/
        }
    }
}