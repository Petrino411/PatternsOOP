using PatternsOOP.Interfaces;
using PatternsOOP.Patterns;

namespace PatternsOOP.PatternsDemo;

public class ObserverDemo : IPatternDemo
{
    public string PatternName => "Observer";

    public void RunDemo()
    {
        Console.WriteLine("Демонстрация паттерна Observer...");

        // Создаем метеостанцию
        WeatherStation weatherStation = new WeatherStation();

        // Создаем наблюдателей
        WallDisplay wallDisplay = new WallDisplay();
        MobileDisplay mobileDisplay = new MobileDisplay();

        // Регистрируем наблюдателей на метеостанции
        weatherStation.RegisterObserver(wallDisplay);
        weatherStation.RegisterObserver(mobileDisplay);

        // Изменяем температуру, что вызывает обновление у всех наблюдателей
        Console.WriteLine("Температура изменяется на 25.3°C:");
        weatherStation.SetTemperature(25.3f);

        Console.WriteLine("\nТемпература изменяется на 30.5°C:");
        weatherStation.SetTemperature(30.5f);

        // Удаляем одного наблюдателя
        weatherStation.RemoveObserver(wallDisplay);

        Console.WriteLine("\nТемпература изменяется на 28.0°C (после удаления WallDisplay):");
        weatherStation.SetTemperature(28.0f);
    }
}
public class MobileDisplay : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine("Мобильный телефон: температура обновлена: " + temperature + "°C");
    }
}