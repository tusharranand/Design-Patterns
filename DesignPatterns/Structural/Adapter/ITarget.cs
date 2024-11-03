namespace Structural.Adapter
{
    public interface ITarget
    {
        string GetRequest();
        bool InputCSVIntermediateMethod(string inputCSV);
        bool InputXMLIntermediateMethod(string inputXML);
    }
}