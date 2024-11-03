
namespace Structural.Adapter
{
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific Request";
        }

        internal bool FinalMethodExpectsJSON(string jSONInput)
        {
            Console.WriteLine("Final method expects JSON. Returns bool based on successfull execution/usage of input JSON.");
            Console.WriteLine($"Received input: {jSONInput}\nPress any button to proceed...");
            _ = Console.ReadKey();
            return true;
        }
    }
}