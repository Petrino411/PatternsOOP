namespace PatternsOOP.Patterns;

public interface IPaymentStrategy
{
    void Pay(decimal amount);
}

// Конкретная стратегия оплаты через кредитную карту
public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Оплачено {amount} используя кредитку.");
    }
}

// Конкретная стратегия оплаты через PayPal
public class PayPalPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Оплачено {amount} используя PayPal.");
    }
}

// Конкретная стратегия оплаты через Bitcoin
public class BitcoinPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Оплачено {amount} через Bitcoin.");
    }
}

// Контекст, использующий стратегию оплаты
public class ShoppingCart
{
    private IPaymentStrategy _paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void Checkout(decimal amount)
    {
        if (_paymentStrategy == null)
        {
            Console.WriteLine("Не выбран метод оплаты");
            return;
        }
        
        _paymentStrategy.Pay(amount);
    }
}

