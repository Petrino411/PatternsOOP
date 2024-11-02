namespace PatternsOOP.Patterns;

// Интерфейс наблюдателя
public interface IObserver
{
    void Update(float temperature);
}

// Интерфейс субъекта
public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}

// Субъект (метеостанция)
public class WeatherStation : ISubject
{
    private List<IObserver> observers;
    private float temperature;

    public WeatherStation()
    {
        observers = new List<IObserver>();
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
        {
            observer.Update(temperature);
        }
    }

    public void SetTemperature(float newTemperature)
    {
        temperature = newTemperature;
        NotifyObservers();
    }
}

// Конкретный наблюдатель (например, дисплей на стене)
public class WallDisplay : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine("Стена: температура обновлена " + temperature + "°C");
    }
}
