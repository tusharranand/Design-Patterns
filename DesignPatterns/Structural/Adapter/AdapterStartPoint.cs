namespace Structural.Adapter
{
    public static class AdapterStartPoint
    {
        public static void StartAdapterDemo()
        {
            Adaptee adaptee = new();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter, client can call it's method.\nPress any key to proceed...");
            _ = Console.ReadKey();

            Console.WriteLine(target.GetRequest());

            Console.Write("\nTry Usage Example? (y/n): ");
            string example = Console.ReadLine();
            if (!string.IsNullOrEmpty(example) && example.ToLower() == "y")
            {
                Console.WriteLine("Client sends XML/CSV data but the API expects JSON.");
                string inputXML = "\"This is an XML string\"";
                Console.WriteLine($"Sending dummy XML input.{inputXML}\nPress any key to proceed...");
                _ = Console.ReadKey();

                _ = target.InputXMLIntermediateMethod(inputXML);

                string inputCSV = "\"This is a CSV string\"";
                Console.WriteLine($"Sending dummy CSV input.{inputCSV}\nPress any key to proceed...");
                _ = Console.ReadKey();

                _ = target.InputCSVIntermediateMethod(inputCSV);

            }
        }
    }
}
