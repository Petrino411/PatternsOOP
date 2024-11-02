using PatternsOOP.Interfaces;
using PatternsOOP.Patterns;

namespace PatternsOOP.PatternsDemo;

public class CommandDemo : IPatternDemo
{
    public string PatternName => "Command";

    public void RunDemo()
    {
        Console.WriteLine("Демонстрация паттерна Command...");

        // Создаем объект света (получателя команды)
        Light livingRoomLight = new Light();

        // Создаем команды для управления светом
        ICommand lightOnCommand = new LightOnCommand(livingRoomLight);
        ICommand lightOffCommand = new LightOffCommand(livingRoomLight);

        // Создаем пульт управления
        RemoteControl remoteControl = new RemoteControl();

        // Включаем свет с помощью команды
        Console.WriteLine("Включаем свет через пульт:");
        remoteControl.SetCommand(lightOnCommand);

        // Выключаем свет с помощью команды
        Console.WriteLine("Выключаем свет через пульт:");
        remoteControl.SetCommand(lightOffCommand);

        // Отменяем последнюю команду (включаем свет)
        Console.WriteLine("Отмена последней команды (включаем свет):");
        remoteControl.UndoLastCommand();

        // Отменяем еще раз (выключаем свет)
        Console.WriteLine("Отмена последней команды (выключаем свет):");
        remoteControl.SetCommand(lightOffCommand);
        remoteControl.UndoLastCommand();
    }
}