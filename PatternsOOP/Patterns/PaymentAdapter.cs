namespace PatternsOOP.Patterns;

public interface IPayment
{
    void Pay(string cardNumber, decimal amount);
}

public class PaymentAdapter : IPayment
{
    private readonly OldPaymentSystem _oldPaymentSystem;

    public PaymentAdapter(OldPaymentSystem oldPaymentSystem)
    {
        _oldPaymentSystem = oldPaymentSystem;
    }

    public void Pay(string cardNumber, decimal amount)
    {
        _oldPaymentSystem.ProcessTransaction(cardNumber, amount);
    }
}

public class OldPaymentSystem
{
    public void ProcessTransaction(string cardNumber, decimal amount)
    {
        Console.WriteLine($"Обрабатывается транзакция на сумму {amount} по карте: {cardNumber}");
    }
}


