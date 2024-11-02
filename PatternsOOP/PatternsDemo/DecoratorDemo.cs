using PatternsOOP.Interfaces;
using PatternsOOP.Patterns;

namespace PatternsOOP.PatternsDemo;

public class DecoratorDemo : IPatternDemo
{
    public string PatternName => "Decorator";

    public void RunDemo()
    {
        Console.WriteLine("Демонстрация паттерна Decorator...");

        // Базовое уведомление
        INotifier notifier = new BasicNotifier();

        // Оборачиваем базовое уведомление в EmailDecorator
        INotifier emailNotifier = new EmailDecorator(notifier);

        // Оборачиваем в SMSDecorator
        INotifier smsNotifier = new SMSDecorator(emailNotifier);

        // Отправляем сообщение (декораторы добавляют email и SMS к базовому уведомлению)
        Console.WriteLine("Отправка уведомления с базовым, email и SMS:");
        smsNotifier.Send("Это задекорированное сообщение");

        // Пример с другим набором декораторов
        INotifier anotherNotifier = new SMSDecorator(new BasicNotifier());
        Console.WriteLine("\nОтправка уведомления только с базовым и SMS:");
        anotherNotifier.Send("Другой пример уведомления");
    }
}