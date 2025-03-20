using ReactiveUI;

namespace Task2.Models;

public abstract class Figure(Color color, Position position) : ReactiveObject
{
    public Color Color { get; set; } = color;
    
    private Position _position = position;
    public Position Position 
    { 
        get => _position;
        private set => this.RaiseAndSetIfChanged(ref _position, value);
    }
    
    public void Move(Position newPosition)
    {
        if (CanMove(newPosition) && InField(newPosition))
        {
            Position = newPosition;
        }
    }
    
    public string Name => GetType().Name;

    protected abstract bool CanMove(Position newPosition);

    private static bool InField(Position newPosition)
    {
        return newPosition.X is > 0 and < 8 && newPosition.Y is > 0 and < 8;
    }
}