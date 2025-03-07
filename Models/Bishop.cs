using System;

namespace ChessApp.Models
{
    public class Bishop : ChessPiece
    {
        public Bishop(string color, (int X, int Y) position) : base(color, position) { }

        protected override bool CanMove((int X, int Y) newPosition)
        {
            // Слон может ходить только по диагонали
            return Math.Abs(newPosition.X - Position.X) == Math.Abs(newPosition.Y - Position.Y);
        }
    }
}