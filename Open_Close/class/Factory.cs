using System;
using System.Collections.Generic;

namespace OpenClosedPrincipleViolation
{
    public sealed class Factory
    {

        /*        public Production CraftWood(IEnumerable<Wood> manyWoodBlocks)
                {
                    Production newProduction = new Production(manyWoodBlocks);
                    return newProduction;
                }

                public Production CraftMetal(IEnumerable<Metal> manyMetalBlocks)
                {
                    Production newProduction = new Production(manyMetalBlocks);
                    return newProduction;
                }*/
        public Production Craft(IEnumerable<Craftable> craftables)
        {
            Production production = new Production(craftables);
            return production;
        }
    }
}