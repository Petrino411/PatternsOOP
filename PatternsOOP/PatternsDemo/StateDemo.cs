using PatternsOOP.Interfaces;
using PatternsOOP.Patterns;

namespace PatternsOOP.PatternsDemo;

public class StateDemo : IPatternDemo
{
    public string PatternName => "State";

    public void RunDemo()
    {
        Console.WriteLine("Демонстрация паттерна State...");

        // Создаем объект телевизора
        TvContext tv = new TvContext();

        // Пытаемся переключить канал, пока телевизор выключен
        Console.WriteLine("Попытка сменить канал при выключенном телевизоре:");
        tv.ChangeChannel(5);

        // Включаем телевизор
        Console.WriteLine("\nВключение телевизора:");
        tv.TurnOn();

        // Переключаем канал, когда телевизор включен
        Console.WriteLine("\nСмена канала на 10:");
        tv.ChangeChannel(10);

        // Выключаем телевизор
        Console.WriteLine("\nВыключение телевизора:");
        tv.TurnOff();

        // Пытаемся снова переключить канал, когда телевизор выключен
        Console.WriteLine("\nПопытка сменить канал при выключенном телевизоре:");
        tv.ChangeChannel(7);
    }
}