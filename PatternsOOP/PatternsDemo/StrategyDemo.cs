using PatternsOOP.Interfaces;
using PatternsOOP.Patterns;

namespace PatternsOOP.PatternsDemo;

public class StrategyDemo : IPatternDemo
{
    public string PatternName => "Strategy";

    public void RunDemo()
    {
        Console.WriteLine("Демонстрация паттерна Strategy...");

        // Создаем объект корзины
        ShoppingCart cart = new ShoppingCart();

        // Устанавливаем стратегию оплаты через кредитную карту
        Console.WriteLine("Выбор оплаты через кредитную карту:");
        cart.SetPaymentStrategy(new CreditCardPayment());
        cart.Checkout(100.00m);

        // Меняем стратегию на оплату через PayPal
        Console.WriteLine("\nВыбор оплаты через PayPal:");
        cart.SetPaymentStrategy(new PayPalPayment());
        cart.Checkout(200.50m);

        // Меняем стратегию на оплату через Bitcoin
        Console.WriteLine("\nВыбор оплаты через Bitcoin:");
        cart.SetPaymentStrategy(new BitcoinPayment());
        cart.Checkout(0.03m);
    }
}