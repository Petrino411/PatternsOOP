namespace PatternsOOP.Patterns;

public class TV
{
    public void TurnOn() => Console.WriteLine("Телевизор включен");
    public void SetInputChannel() => Console.WriteLine("Тип входного сигнала - DVD");
}

public class DVDPlayer
{
    public void TurnOn() => Console.WriteLine("DVD включен");
    public void Play() => Console.WriteLine("DVD проигрывается.");
}

public class SoundSystem
{
    public void TurnOn() => Console.WriteLine("Звуковая система включена");
    public void SetVolume(int level) => Console.WriteLine($"Громкость - {level}.");
}

// Фасад, упрощающий управление домашним кинотеатром
public class HomeTheaterFacade
{
    private readonly TV _tv;
    private readonly DVDPlayer _dvdPlayer;
    private readonly SoundSystem _soundSystem;

    public HomeTheaterFacade(TV tv, DVDPlayer dvdPlayer, SoundSystem soundSystem)
    {
        _tv = tv;
        _dvdPlayer = dvdPlayer;
        _soundSystem = soundSystem;
    }

    public void WatchMovie()
    {
        Console.WriteLine("Готовность смотреть фильм...");
        _tv.TurnOn();
        _tv.SetInputChannel();
        _dvdPlayer.TurnOn();
        _dvdPlayer.Play();
        _soundSystem.TurnOn();
        _soundSystem.SetVolume(5);
    }
}
