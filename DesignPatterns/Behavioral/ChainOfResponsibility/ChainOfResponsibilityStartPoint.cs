namespace Behavioral.ChainOfResponsibility
{
    public class ChainOfResponsibilityStartPoint
    {
        public static void StartChainOfResponsibilityDemo()
        {
            MonkeyHandler monkey = new();
            SquirrelHandler squirrel = new();
            DogHandler dog = new();

            _ = monkey.SetNext(squirrel).SetNext(dog);

            Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            ClientCode(monkey);
            Console.WriteLine();

            Console.WriteLine("Subchain: Squirrel > Dog\n");
            ClientCode(squirrel);
        }

        private static void ClientCode(AbstractHandler handler)
        {
            foreach (string food in new List<string> { "Nut", "Banana", "Cup of coffee" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                object result = handler.Handle(food);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} was left untouched.");
                }
            }
        }
    }
}
