//1. Base Class: ChemicalEntity
public abstract class ChemicalEntity
{
    protected string _name;
    protected string _formula;

    public ChemicalEntity(string name, string formula)
    {
        _name = name;
        _formula = formula;
    }

    public abstract double GetMolarMass();
}

