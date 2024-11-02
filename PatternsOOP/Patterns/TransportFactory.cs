namespace PatternsOOP.Patterns;

public interface ITransport
{
    void Deliver();
}

public class Car : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Доставка машиной");
    }
}

public class Bike : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Доставка велосипедом");
    }
}

public abstract class TransportFactory
{
    protected abstract ITransport CreateTransport();
    
    public void DeliverPackage(string destination)
    {
        var transport = CreateTransport();
        Console.WriteLine($"Инициализация доставки в {destination} используя {transport.GetType().Name}...");
        transport.Deliver();
        Console.WriteLine($"Доставлено в {destination} используя {transport.GetType().Name}.");
    }
}

public class CarFactory : TransportFactory
{
    protected override ITransport CreateTransport()
    {
        return new Car();
    }
}

public class BikeFactory : TransportFactory
{
    protected override ITransport CreateTransport()
    {
        return new Bike();
    }
}