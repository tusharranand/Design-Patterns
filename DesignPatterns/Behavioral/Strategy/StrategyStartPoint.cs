namespace Behavioral.Strategy
{
    public class StrategyStartPoint
    {
        public static void StartStrategyDemo()
        {
            Context context = new();

            Console.WriteLine("Client says: Strategy is set to normal sorting. Press any key to proceed...");
            _ = Console.ReadKey();
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine("Client says: Strategy is set to reverse sorting. Press any key to proceed...");
            _ = Console.ReadKey();
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();
        }
    }
}
