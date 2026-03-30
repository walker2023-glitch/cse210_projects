//4. Base Class: ChemTool
public abstract class ChemTool
{
    protected string _toolName;

    public ChemTool(string name) => _toolName = name;

    public string GetName() => _toolName;

    //This is our polymorphic method, the child classes create their own run methods
    public abstract void Run();
}

