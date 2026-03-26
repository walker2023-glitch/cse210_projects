//8. Class: AppEngine
public class AppEngine
{
    private List<ChemTool> _tools = new List<ChemTool>();

    public AppEngine()
    {
        //Polymorphism: Adding different tools to the same list
        _tools.Add(new MolarMassTool());
        _tools.Add(new GasLawTool());
        _tools.Add(new StoichiometryTool());
    }

/*
The main loop simply creates our menu in the console.
It dynamically creates the list based on how many tools we have.
Which means that even if we add more tools we don't have to change this code.
*/
    public void MainLoop()
    {
        string choice = "";
        while (choice != "0")
        {
            Console.WriteLine("\n--- Chemistry Calculator ---");
            for (int i = 0; i < _tools.Count; i++) //Creates menu dynamically
            {
                Console.WriteLine($"{i + 1}. {_tools[i].GetName()}");
            }
            Console.WriteLine("0. Quit");
            Console.Write("Select a tool: ");
            choice = Console.ReadLine();

            if (int.TryParse(choice, out int index) && index > 0 && index <= _tools.Count)//this validates that the input can be parsed and is within the range
            {
                _tools[index - 1].Run();
                //This way allows for much shorter code instead of a bunch of else if statements
            }
        }
    }
}
