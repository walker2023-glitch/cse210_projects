// 6. Derived Tool: GasLawTool
public class GasLawTool : ChemTool
{
    // The Ideal Gas Constant (L*atm / mol*K)
    private const double R = 0.0821;

    public GasLawTool() : base("Ideal Gas Law Solver") { }

    public override void Run()
    {
        Console.WriteLine("\n--- Ideal Gas Law Solver (PV = nRT) ---");
        Console.WriteLine("Which variable would you like to solve for?");
        Console.WriteLine("1. Pressure (P) in atm");
        Console.WriteLine("2. Volume (V) in L");
        Console.WriteLine("3. Moles (n)");
        Console.WriteLine("4. Temperature (T) in K");
        Console.Write("Choice: ");
        string choice = Console.ReadLine();

        //Just a little method to keep this cleaner and demonstrate abstraction
        Solve(choice);
    }

    private void Solve(string choice)
    {
        /*
        This provides equations for each scenario based on what
        unknown they are looking for.  I tried to figure out if
        there was a smarter way to do this dynamically that required
        less code.  But hey, it works \(OvO)/
        */
        try 
        {
            if (choice == "1") //Solves for P = nRT / V
            {
                double n = GetInput("Moles (n)");
                double T = GetInput("Temperature (T in Kelvin)");
                double V = GetInput("Volume (V in Liters)");
                double P = (n * R * T) / V;
                Console.WriteLine($"\nResult: Pressure (P) = {P:F3} atm");
            }
            else if (choice == "2") //Solves for V = nRT / P
            {
                double n = GetInput("Moles (n)");
                double T = GetInput("Temperature (T in Kelvin)");
                double P = GetInput("Pressure (P in atm)");
                double V = (n * R * T) / P;
                Console.WriteLine($"\nResult: Volume (V) = {V:F3} L");
            }
            else if (choice == "3") //Solves for n = PV / RT
            {
                double P = GetInput("Pressure (P in atm)");
                double V = GetInput("Volume (V in Liters)");
                double T = GetInput("Temperature (T in Kelvin)");
                double n = (P * V) / (R * T);
                Console.WriteLine($"\nResult: Amount (n) = {n:F4} moles");
            }
            else if (choice == "4") //Solves for T = PV / nR
            {
                double P = GetInput("Pressure (P in atm)");
                double V = GetInput("Volume (V in Liters)");
                double n = GetInput("Moles (n)");
                double T = (P * V) / (n * R);
                Console.WriteLine($"\nResult: Temperature (T) = {T:F2} K");
            }
        }
        catch (Exception) //Error handling to make sure weird things don't get inputted
        {
            Console.WriteLine("Error: Please enter valid numerical values.");
        }
    }

    //Helper method to help reduce repeated code (yay functional programming)
    private double GetInput(string label)
    {
        Console.Write($"Enter {label}: ");
        return double.Parse(Console.ReadLine());
    }
}