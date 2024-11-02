using PatternsOOP.Interfaces;
using PatternsOOP.Patterns;

namespace PatternsOOP.PatternsDemo;

public class AdapterDemo : IPatternDemo
{
    public string PatternName => "Adapter";

    public void RunDemo()
    {
        Console.WriteLine("Демонстрация паттерна Adapter...");

        // Создаем экземпляр старой платежной системы
        var oldPaymentSystem = new OldPaymentSystem();

        // Оборачиваем старую платежную систему адаптером, чтобы работать через IPayment
        IPayment paymentAdapter = new PaymentAdapter(oldPaymentSystem);

        // Используем адаптер для оплаты через интерфейс IPayment
        Console.WriteLine("Оплата с использованием адаптера:");
        paymentAdapter.Pay("1234-5678-9012-3456", 150.75m);

        Console.WriteLine("\nОплата с использованием другого номера карты:");
        paymentAdapter.Pay("9876-5432-1098-7654", 500.00m);
    }
}