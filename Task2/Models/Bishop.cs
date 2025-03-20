using System;

namespace Task2.Models;

public class Bishop(Color color, Position position) : Figure(color, position)
{
    protected override bool CanMove(Position newPosition)
    {
        return Math.Abs(newPosition.X - Position.X) == Math.Abs(newPosition.Y - Position.Y);
    }
}