namespace PatternsOOP.Patterns;

public interface ICommand
{
    void Execute();
    void Undo();
}
// Конкретная команда включения света
public class LightOnCommand : ICommand
{
    private Light _light;

    public LightOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.On();
    }

    public void Undo()
    {
        _light.Off();
    }
}

// Конкретная команда выключения света
public class LightOffCommand : ICommand
{
    private Light _light;

    public LightOffCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.Off();
    }

    public void Undo()
    {
        _light.On();
    }
}

// Получатель команды - свет
public class Light
{
    public void On()
    {
        Console.WriteLine("Свет включен");
    }
    public void Off()
    {
        Console.WriteLine("Свет выключен");
    }
}

// Контроллер, управляющий командами
public class RemoteControl
{
    private ICommand _lastCommand;

    public void SetCommand(ICommand command)
    {
        _lastCommand = command;
        _lastCommand.Execute();
    }

    public void UndoLastCommand()
    {
        if (_lastCommand != null)
        {
            _lastCommand.Undo();
        }
    }
}
