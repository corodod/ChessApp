namespace Task2.Models;

public record struct Position(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    public string PositionString => $"x:{X}, y:{Y}";

    public bool Equals(Position? other)
    {
        return other?.X == X && other?.Y == Y;
    }
}