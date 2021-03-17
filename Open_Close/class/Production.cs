using System.Collections.Generic;

namespace OpenClosedPrincipleViolation
{
    public class Production
    {
        public IEnumerable<Craftable> Craftables { get; }

        public Production(IEnumerable<Craftable> craftables)
        {
            Craftables = craftables;
        }

        public override string ToString()
        {
            string description = "Object is composed of\n:";
            foreach (Craftable material in Craftables)
            {
                description += "\t" + material.Type;
            }
            return description;
        }
    }
}