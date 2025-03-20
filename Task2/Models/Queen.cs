using System;

namespace Task2.Models;

public class Queen(Color color, Position position) : Figure(color, position)
{
    protected override bool CanMove(Position newPosition)
    {
        return newPosition.X == Position.X || newPosition.Y == Position.Y ||
               Math.Abs(newPosition.X - Position.X) == Math.Abs(newPosition.Y - Position.Y);    }
}