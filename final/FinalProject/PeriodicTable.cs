//9. Our Periodic Table Data Base
public static class PeriodicTable
{
    //This private dictionary ensures that our data remain encapsulated and read-only to the outside world
    private static Dictionary<string, double> _elements = new Dictionary<string, double>
    {
        // Period 1
        {"H", 1.008}, {"He", 4.0026},
        
        // Period 2
        {"Li", 6.94}, {"Be", 9.0122}, {"B", 10.81}, {"C", 12.011}, 
        {"N", 14.007}, {"O", 15.999}, {"F", 18.998}, {"Ne", 20.180},
        
        // Period 3
        {"Na", 22.990}, {"Mg", 24.305}, {"Al", 26.982}, {"Si", 28.085}, 
        {"P", 30.974}, {"S", 32.06}, {"Cl", 35.45}, {"Ar", 39.948},
        
        // Period 4 (Commonly used elements)
        {"K", 39.098}, {"Ca", 40.078}, {"Ti", 47.867}, {"Cr", 51.996},
        {"Mn", 54.938}, {"Fe", 55.845}, {"Co", 58.933}, {"Ni", 58.693},
        {"Cu", 63.546}, {"Zn", 65.38}, {"Br", 79.904}, {"Kr", 83.798},
        
        // Period 5 & 6 (Heavy hitters)
        {"Ag", 107.87}, {"Sn", 118.71}, {"I", 126.90}, {"Ba", 137.33},
        {"Pt", 195.08}, {"Au", 196.97}, {"Hg", 200.59}, {"Pb", 207.2},
        {"U", 238.03}
    };

    //Public method to safely access the data, in other words, our "getter".
    public static double GetMass(string symbol)
    {
        //Checks if the symbol exists to prevent the program from crashing
        if (_elements.ContainsKey(symbol)) 
        {
            return _elements[symbol];
        }
        else 
        {
            //If element is not found, we alert the user
            Console.WriteLine($"Error: Element '{symbol}' not found in the Periodic Table.");
            return 0;
        }
    }
}