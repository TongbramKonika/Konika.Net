using System;

namespace InterfaceExample
{
    // Define the first interface
    public interface IMovable
    {
        void Move();
    }

    // Define the second interface
    public interface IRechargeable
    {
        void Recharge();
    }

    // Implementing both interfaces in a class
    public class Robot : IMovable, IRechargeable
    {
        public void Move()
        {
            Console.WriteLine("The robot is moving.");
        }

        public void Recharge()
        {
            Console.WriteLine("The robot is recharging.");
        }
    }

    class Program
    {
        static void Main()
        {
            Robot robot = new Robot();

            // Calling methods from both interfaces
            robot.Move();      // From IMovable
            robot.Recharge();  // From IRechargeable
        }
    }
}
