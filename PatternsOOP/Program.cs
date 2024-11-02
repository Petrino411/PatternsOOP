using PatternsOOP.PatternsDemo;

namespace PatternsOOP;

class Program
{
    static void Main(string[] args)
    {
        PatternManager manager = new PatternManager();

        RegisterPatterns(manager);
        
        Console.WriteLine("Доступные паттерны:");
        foreach (var patternName in manager.Patterns.Keys)
        {
            Console.WriteLine($"- {patternName}");
        }

        Console.WriteLine("Введите название паттерна для запуска:");
        var input = Console.ReadLine();
        manager.RunPattern(input);
    }

    static void RegisterPatterns(PatternManager manager)
    {
        manager.RegisterPattern(new SingletonDemo());
        manager.RegisterPattern(new FactoryDemo());
        manager.RegisterPattern(new BuilderDemo());
        manager.RegisterPattern(new AdapterDemo());
        manager.RegisterPattern(new DecoratorDemo());
        manager.RegisterPattern(new FacadeDemo());
        manager.RegisterPattern(new ObserverDemo());
        manager.RegisterPattern(new StrategyDemo());
        manager.RegisterPattern(new CommandDemo());
        manager.RegisterPattern(new StateDemo());
    }
}