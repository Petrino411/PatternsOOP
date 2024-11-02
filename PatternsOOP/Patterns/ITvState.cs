namespace PatternsOOP.Patterns;

// Интерфейс состояния
public interface ITvState
{
    void TurnOn(TvContext context);
    void TurnOff(TvContext context);
    void ChangeChannel(TvContext context, int channel);
}

// Телевизор включен
public class OnState : ITvState
{
    public void TurnOn(TvContext context)
    {
        Console.WriteLine("Телевизор уже включен");
    }

    public void TurnOff(TvContext context)
    {
        Console.WriteLine("Выключение телевизора");
        context.SetState(new OffState());
    }

    public void ChangeChannel(TvContext context, int channel)
    {
        Console.WriteLine($"Переключение канала на {channel}.");
    }
}

// Телевизор выключен
public class OffState : ITvState
{
    public void TurnOn(TvContext context)
    {
        Console.WriteLine("Включение телевизора.");
        context.SetState(new OnState());
    }

    public void TurnOff(TvContext context)
    {
        Console.WriteLine("Телевизор уже выключен");
    }

    public void ChangeChannel(TvContext context, int channel)
    {
        Console.WriteLine("Нельзя сменить канал пока телевизор выключен");
    }
}

// Контекст - телевизор
public class TvContext
{
    private ITvState _state;

    public TvContext()
    {
        _state = new OffState(); // Начальное состояние - выключен
    }

    public void SetState(ITvState state)
    {
        _state = state;
    }

    public void TurnOn()
    {
        _state.TurnOn(this);
    }

    public void TurnOff()
    {
        _state.TurnOff(this);
    }

    public void ChangeChannel(int channel)
    {
        _state.ChangeChannel(this, channel);
    }
}
