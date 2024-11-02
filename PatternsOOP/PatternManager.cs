using Microsoft.VisualBasic;
using PatternsOOP.Interfaces;
using PatternsOOP.PatternsDemo;

namespace PatternsOOP;

public class PatternManager
{
    public Dictionary<string, IPatternDemo> Patterns = new Dictionary<string, IPatternDemo>();

    public void RegisterPattern(IPatternDemo pattern)
    {
        Patterns[pattern.PatternName] = pattern;
    }

    public void RunPattern(string patternName)
    {
        if (Patterns.ContainsKey(patternName))
        {
            Patterns[patternName].RunDemo();
        }
        else
        {
            Console.WriteLine("Паттерн не найден.");
        }
    }
    
}