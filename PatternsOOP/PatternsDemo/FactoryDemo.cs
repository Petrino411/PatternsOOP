using PatternsOOP.Interfaces;
using PatternsOOP.Patterns;

namespace PatternsOOP.PatternsDemo;

public class FactoryDemo : IPatternDemo
{
    public string PatternName => "Factory";

    public void RunDemo()
    {
        Console.WriteLine("Демонстрация паттерна Factory...");

        // Демонстрация доставки с использованием машины
        TransportFactory carFactory = new CarFactory();
        Console.WriteLine("Создание доставки машиной:");
        carFactory.DeliverPackage("Москва");

        Console.WriteLine();

        // Демонстрация доставки с использованием велосипеда
        TransportFactory bikeFactory = new BikeFactory();
        Console.WriteLine("Создание доставки велосипедом:");
        bikeFactory.DeliverPackage("КМПО");

        Console.WriteLine();
    }
}