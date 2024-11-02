using PatternsOOP.Interfaces;
using PatternsOOP.Patterns;

namespace PatternsOOP.PatternsDemo;

public class SingletonDemo : IPatternDemo
{
    public string PatternName => "Singleton";

    public void RunDemo()
    {
        Console.WriteLine("Настройка конфигурации через Singleton...");
        
        var config1 = ConfigurationSingleton.Instance;
        config1.LogLevel = "debug";
        config1.SavePath = "/new_logs";
        config1.Language = "ru";
        
        
        var config2 = ConfigurationSingleton.Instance;
        
        Console.WriteLine($"Обе ссылки указывают на один экземпляр: {ReferenceEquals(config1, config2)}");
        
        config2.DisplaySettings();
    }
}