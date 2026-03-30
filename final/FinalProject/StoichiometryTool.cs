//7. Derived Tool: StoichiometryTool
public class StoichiometryTool : ChemTool
{
    public StoichiometryTool() : base("Stoichiometry Converter") {}

    public override void Run()
    {
        Console.WriteLine("\n--- Stoichiometry Converter ---");
        Console.Write("Enter the chemical formula (e.g., H2O): ");
        string formula = Console.ReadLine();
        
        //Automatically returns the molar mass to be used for calculations
        Compound comp = new Compound(formula);
        double molarMass = comp.GetMolarMass();

        if (molarMass == 0) return; //Exits if element wasn't found because if the molarmass is zero well, they probably didn't have the correct input

        Console.WriteLine($"Molar Mass of {formula}: {molarMass} g/mol");
        Console.WriteLine("What are you starting with?");
        Console.WriteLine("1. Grams");
        Console.WriteLine("2. Moles");
        Console.Write("Choice: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("Enter mass in grams: ");
            double grams = double.Parse(Console.ReadLine());
            // Math: Moles = Grams / Molar Mass
            double moles = grams / molarMass;
            Console.WriteLine($"\nResults for {grams}g of {formula}:");
            Console.WriteLine($"{moles:F4} moles");
            Console.WriteLine($"{moles * 6.022e23:E3} molecules");
        }
        else if (choice == "2")
        {
            Console.Write("Enter amount in moles: ");
            double moles = double.Parse(Console.ReadLine());
            // Math: Grams = Moles * Molar Mass
            double grams = moles * molarMass;
            Console.WriteLine($"\nResults for {moles} moles of {formula}:");
            Console.WriteLine($"{grams:F2} grams");
            Console.WriteLine($"{moles * 6.022e23:E3} molecules");
        }
    }
}