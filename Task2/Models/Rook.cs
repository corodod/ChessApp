namespace Task2.Models;

public class Rook(Color color, Position position) : Figure(color, position)
{
    protected override bool CanMove(Position newPosition)
    {
        return newPosition.X == Position.X || newPosition.Y == Position.Y;
    }
}