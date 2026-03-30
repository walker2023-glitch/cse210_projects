//2. Derived Class: Element
public class Element : ChemicalEntity
{
    private double _atomicMass; //Private for Encapsulation
    private string _symbol;

    public Element(string name, string symbol, double mass) : base(name, symbol)
    {
        _symbol = symbol;
        _atomicMass = mass;
    }

    public string GetSymbol() => _symbol;
    
    // Public getter protects the private variable
    public override double GetMolarMass() => _atomicMass;
}