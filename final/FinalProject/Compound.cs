using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Compound : ChemicalEntity
{
    private double _totalMass = 0;

    public Compound(string formula) : base("Chemical Compound", formula)
    {
        _totalMass = ParseAndCalculate();
    }

    private double ParseAndCalculate()
    {
        double total = 0;
        
        // Regex pattern: Group 1 is the Symbol, Group 2 is the optional Number
        string pattern = @"([A-Z][a-z]?)(\d*)";
        
        foreach (Match match in Regex.Matches(_formula, pattern))
        {
            string symbol = match.Groups[1].Value;
            string countStr = match.Groups[2].Value;

            int quantity = string.IsNullOrEmpty(countStr) ? 1 : int.Parse(countStr);

            // Accessing the static PeriodicTable class
            double elementMass = PeriodicTable.GetMass(symbol);
            total += (elementMass * quantity);
        }

        return total;
    }

    // This overrides the abstract method in the base ChemicalEntity class
    public override double GetMolarMass()
    {
        return _totalMass;
    }
}