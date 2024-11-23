using Behavioral.ChainOfResponsibility;
using Behavioral.Strategy;
using Structural.Adapter;

namespace DesignPatterns
{
    internal class Program
    {
        private static void Main()
        {
            int choice = default;
            do
            {
                Console.WriteLine("Enter a number to test related Design Pattern");
                Console.WriteLine("1. Behavioral Patterns");
                Console.WriteLine("2. Creational Patterns");
                Console.WriteLine("3. Structural Patterns");
                Console.WriteLine("4. EXIT");
                try
                {
                    Console.Write("\nEnter your choice here: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Start Behavioral Patterns");
                            StartBehavioralTesting();
                            break;
                        case 2:
                            Console.WriteLine("Start Creational Patterns");
                            StartCreationalTesting();
                            break;
                        case 3:
                            Console.WriteLine("Start Structural Patterns");
                            StartStructuralTesting();
                            break;
                        case 4:
                            Console.WriteLine("Exiting Program.");
                            break;
                        default:
                            Console.WriteLine("Please enter a valid input.\n");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("");
                }
            }
            while (choice != 4);
        }

        private static void StartStructuralTesting()
        {
            int choice = default;
            do
            {
                Console.WriteLine("Enter a number to test related Structural Design Pattern");
                Console.WriteLine("1. Adpter");
                Console.WriteLine("2. Bridge");
                Console.WriteLine("3. Composite");
                Console.WriteLine("4. Decorator");
                Console.WriteLine("5. Facade");
                Console.WriteLine("6. Flyweight");
                Console.WriteLine("7. Proxy");
                Console.WriteLine("8. EXIT");
                try
                {
                    Console.Write("\nEnter yout choice here: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Starting Adapter\n");
                            AdapterStartPoint.StartAdapterDemo();
                            break;
                        case 2:
                            Console.WriteLine("Starting Bridge");
                            break;
                        case 3:
                            Console.WriteLine("Starting Composite");
                            break;
                        case 4:
                            Console.WriteLine("Starting Decorator");
                            break;
                        case 5:
                            Console.WriteLine("Starting Facade");
                            break;
                        case 6:
                            Console.WriteLine("Starting Flyweight");
                            break;
                        case 7:
                            Console.WriteLine("Starting Proxy");
                            break;
                        case 8:
                            Console.WriteLine("Exiting Sub Menu.");
                            break;
                        default:
                            Console.WriteLine("Please enter on of the given options.");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please Enter a valid choice.");
                }
            } while (choice != 8);
        }

        private static void StartCreationalTesting()
        {
            throw new NotImplementedException();
        }

        private static void StartBehavioralTesting()
        {
            int choice = default;
            do
            {
                Console.WriteLine("Enter a number to test related Structural Design Pattern");
                Console.WriteLine("1. Chain of Responsibility");
                Console.WriteLine("2. Command");
                Console.WriteLine("3. Iterator");
                Console.WriteLine("4. Mediator");
                Console.WriteLine("5. Memento");
                Console.WriteLine("6. Observer");
                Console.WriteLine("7. State");
                Console.WriteLine("8. Strategy");
                Console.WriteLine("9. Template");
                Console.WriteLine("10. Visitor");
                Console.WriteLine("11. EXIT");
                try
                {
                    Console.Write("\nEnter yout choice here: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Starting Chain of Responsibility");
                            ChainOfResponsibilityStartPoint.StartChainOfResponsibilityDemo();
                            break;
                        case 2:
                            Console.WriteLine("Starting Command");
                            break;
                        case 3:
                            Console.WriteLine("Starting Iterator");
                            break;
                        case 4:
                            Console.WriteLine("Starting Mediator");
                            break;
                        case 5:
                            Console.WriteLine("Starting Memento");
                            break;
                        case 6:
                            Console.WriteLine("Starting Observer");
                            break;
                        case 7:
                            Console.WriteLine("Starting State");
                            break;
                        case 8:
                            Console.WriteLine("Starting Strategy");
                            StrategyStartPoint.StartStrategyDemo();
                            break;
                        case 9:
                            Console.WriteLine("Starting Template");
                            break;
                        case 10:
                            Console.WriteLine("Starting Visitor");
                            break;
                        case 11:
                            Console.WriteLine("Exiting Sub Menu.");
                            break;
                        default:
                            Console.WriteLine("Please enter on of the given options.");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please Enter a valid choice.");
                }
            } while (choice != 11);
        }
    }
}
