namespace PatternsOOP.Patterns;

public class ComputerBuilder
{
    public string Processor { get; private set; }
    public string RAM { get; private set; }
    public string GraphicsCard { get; private set; }

    public override string ToString()
    {
        return $"Computer [Processor={Processor}, RAM={RAM}, GraphicsCard={GraphicsCard}]";
    }

    // Вложенный класс Builder
    public class Builder
    {
        private readonly ComputerBuilder _computer = new ComputerBuilder();

        public static Builder Create() => new Builder();

        public Builder SetProcessor(string processor)
        {
            _computer.Processor = processor;
            return this;
        }

        public Builder SetRAM(string ram)
        {
            _computer.RAM = ram;
            return this;
        }

        public Builder SetGraphicsCard(string graphicsCard)
        {
            _computer.GraphicsCard = graphicsCard;
            return this;
        }

        public ComputerBuilder Build()
        {
            // Проверка обязательных свойств
            if (string.IsNullOrEmpty(_computer.Processor) || string.IsNullOrEmpty(_computer.RAM))
            {
                throw new InvalidOperationException("Processor and RAM are required.");
            }

            return _computer;
        }
    }
}