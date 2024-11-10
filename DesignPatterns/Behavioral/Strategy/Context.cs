namespace Behavioral.Strategy
{
    internal class Context
    {
        private IStrategy? _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            Console.WriteLine("Setting strategy in context class provided by/set for the client. Press any key to proceed...");
            _ = Console.ReadKey();
            _strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy (context class is not sure how it'll do it)");

            List<string> input = ["b", "c", "e", "d", "a"];
            Console.WriteLine("Input List: " + string.Join(",", input));

            List<string> result = _strategy.DoAlgorithm(input);

            Console.WriteLine("Response List from strategy used: " + string.Join(",", result) + "\n");
        }
    }
}
