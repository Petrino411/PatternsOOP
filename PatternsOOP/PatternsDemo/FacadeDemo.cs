using PatternsOOP.Interfaces;
using PatternsOOP.Patterns;

namespace PatternsOOP.PatternsDemo;

public class FacadeDemo : IPatternDemo
{
    public string PatternName => "Facade";

    public void RunDemo()
    {
        Console.WriteLine("Демонстрация паттерна Facade...");

        // Создаем компоненты системы домашнего кинотеатра
        TV tv = new TV();
        DVDPlayer dvdPlayer = new DVDPlayer();
        SoundSystem soundSystem = new SoundSystem();

        // Создаем фасад для управления кинотеатром
        HomeTheaterFacade homeTheater = new HomeTheaterFacade(tv, dvdPlayer, soundSystem);

        // Запускаем фильм, используя фасад
        Console.WriteLine("Начинаем просмотр фильма с помощью фасада:");
        homeTheater.WatchMovie();
    }
}