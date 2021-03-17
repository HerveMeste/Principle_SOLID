namespace Interface_Segregation_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.LaunchRocket();
            car.Drive(20);

            FlyingCar flyingCar = new FlyingCar();
            flyingCar.LaunchRocket();
            flyingCar.Drive(50);

            SpaceShip spaceShip = new SpaceShip();
            spaceShip.LaunchRocket();
            spaceShip.Drive(500000000);
        }
    }
}
