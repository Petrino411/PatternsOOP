namespace PatternsOOP.Patterns;

public interface INotifier
{
    void Send(string message);
}

public class BasicNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine("Basic Notification: " + message);
    }
}

public class EmailDecorator : INotifier
{
    private readonly INotifier _notifier;

    public EmailDecorator(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void Send(string message)
    {
        _notifier.Send(message);  // Вызов базового уведомления
        Console.WriteLine("Email Notification: " + message);
    }
}


public class SMSDecorator : INotifier
{
    private readonly INotifier _notifier;

    public SMSDecorator(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void Send(string message)
    {
        _notifier.Send(message);  // Вызов базового уведомления
        Console.WriteLine("SMS Notification: " + message);
    }
}


