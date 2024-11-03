namespace Structural.Adapter
{
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            Console.WriteLine("Implmenting GetRequest method from Adapter class.\nPress any key to proceed...");
            _ = Console.ReadKey();
            return $"This is '{_adaptee.GetSpecificRequest()}'";
        }

        public bool InputCSVIntermediateMethod(string inputCSV)
        {
            Console.WriteLine("This is an intermediate method that accepts CSV input and converts it to JSON.\nPress any key to proceed...");
            _ = Console.ReadKey();
            string JSONInput = inputCSV.Replace("CSV", "JSON");
            return _adaptee.FinalMethodExpectsJSON(JSONInput);
        }

        public bool InputXMLIntermediateMethod(string inputXML)
        {
            Console.WriteLine("This is an intermediate method that accepts XML input and converts it to JSON.\nPress any key to proceed...");
            _ = Console.ReadKey();
            string JSONInput = inputXML.Replace("XML", "JSON");
            return _adaptee.FinalMethodExpectsJSON(JSONInput);
        }
    }
}
