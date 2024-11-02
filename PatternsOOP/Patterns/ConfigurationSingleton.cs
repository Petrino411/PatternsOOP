namespace PatternsOOP.Patterns;

public class ConfigurationSingleton
{
    
    private static readonly Lazy<ConfigurationSingleton> _instance = new Lazy<ConfigurationSingleton>(() => new ConfigurationSingleton());

    private ConfigurationSingleton()
    {
        LogLevel = "info";
        SavePath = "/logs";
        Language = "en";
    }
    
    public static ConfigurationSingleton Instance => _instance.Value;

    // ConfigurationSingleton? _instance;
    // private static readonly object _lock = new object();
    //
    // private ConfigurationSingleton()
    // {
    //     LogLevel = "info";
    //     SavePath = "/logs";
    //     Language = "en";
    // }
    //
    //
    // public ConfigurationSingleton Instance
    // {
    //     get
    //     {
    //         if (_instance == null)
    //         {
    //             lock (_lock)
    //             {
    //                 if (_instance == null)
    //                 {
    //                     _instance = new ConfigurationSingleton();
    //                 }
    //             }
    //         }
    //         return _instance;
    //     }
    // }
    

    public string LogLevel { get; set; }
    public string SavePath { get; set; }
    public string Language { get; set; }

    public void DisplaySettings()
    {
        Console.WriteLine($"LogLevel: {LogLevel}, SavePath: {SavePath}, Language: {Language}");
    }
}