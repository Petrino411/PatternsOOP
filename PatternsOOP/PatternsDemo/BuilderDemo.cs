using PatternsOOP.Interfaces;
using PatternsOOP.Patterns;

namespace PatternsOOP.PatternsDemo;

public class BuilderDemo : IPatternDemo
{
    public string PatternName => "Builder";

    public void RunDemo()
    {
        Console.WriteLine("Демонстрация паттерна Builder...");
        
        var gamingComputer = ComputerBuilder.Builder.Create()
            .SetProcessor("Intel i9")
            .SetRAM("32GB")
            .SetGraphicsCard("NVIDIA RTX 3080")
            .Build();
        
        Console.WriteLine("Создан игровой компьютер:");
        Console.WriteLine(gamingComputer);

        Console.WriteLine();
        
        var officeComputer = ComputerBuilder.Builder.Create()
            .SetProcessor("Intel i5")
            .SetRAM("16GB")
            .Build();

        Console.WriteLine("Создан офисный компьютер:");
        Console.WriteLine(officeComputer);
        
        try
        {
            var incompleteComputer = ComputerBuilder.Builder.Create()
                .SetGraphicsCard("Integrated")
                .Build();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Ошибка при создании компьютера: " + ex.Message);
        }
    }
}