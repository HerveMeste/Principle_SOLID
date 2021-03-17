using System;

namespace Interface_Segregation_Principle
{
    class SpaceShip : IDrivable, IRocketLaunchable
    {
        private bool _isRocketLaunched;

        public void Drive(long miles)
        {
            if (!_isRocketLaunched)
            {
                Console.WriteLine("Spaceship can't leave Earth if its rocket is not launched !");
            }
            else
            {
                Console.WriteLine("The spaceship is going {0} miles away", miles);
            }
        }

        public void LaunchRocket()
        {
            _isRocketLaunched = true;
        }
    }
}
