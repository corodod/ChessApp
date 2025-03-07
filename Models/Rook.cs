namespace ChessApp.Models
{
    public class Rook : ChessPiece
    {
        public Rook(string color, (int X, int Y) position) : base(color, position) { }

        protected override bool CanMove((int X, int Y) newPosition)
        {
            // Ладья может ходить только по прямой
            return newPosition.X == Position.X || newPosition.Y == Position.Y;
        }
    }
}