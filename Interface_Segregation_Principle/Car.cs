using System;

namespace Interface_Segregation_Principle
{
    class Car : IDrivable, IRocketLaunchable
    {
        public void Drive(long miles)
        {
            Console.WriteLine("I am driven to {0} miles away ...", miles);
        }

        public void LaunchRocket()
        {
            Console.WriteLine("I don't have any rocket to launch ...");
        }
    }
}
