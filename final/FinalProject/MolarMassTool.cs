// 5. Derived Tool: MolarMassTool
public class MolarMassTool : ChemTool
{
    public MolarMassTool() : base("Molar Mass Calculator") {}

    public override void Run()
    {
        Console.Write("Enter a chemical formula: ");
        string formula = Console.ReadLine();
        Compound c = new Compound(formula);
        Console.WriteLine($"The molar mass is: {c.GetMolarMass()} g/mol");
    }
}