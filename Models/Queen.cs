using System;

namespace ChessApp.Models
{
    public class Queen : ChessPiece
    {
        public Queen(string color, (int X, int Y) position) : base(color, position) { }

        protected override bool CanMove((int X, int Y) newPosition)
        {
            // Ферзь может ходить по прямой и по диагонали
            return newPosition.X == Position.X || newPosition.Y == Position.Y ||
                   Math.Abs(newPosition.X - Position.X) == Math.Abs(newPosition.Y - Position.Y);
        }
    }
}