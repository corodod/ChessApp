using System;
using System.ComponentModel;

namespace ChessApp.Models
{
    public abstract class ChessPiece : INotifyPropertyChanged
    {
        private string _color = string.Empty;
        private (int X, int Y) _position = (0, 0);

        public string Color
        {
            get => _color;
            protected set
            {
                _color = value;
                OnPropertyChanged(nameof(Color));
            }
        }

        public (int X, int Y) Position
        {
            get => _position;
            protected set
            {
                _position = value;
                OnPropertyChanged(nameof(Position));
            }
        }

        protected ChessPiece(string color, (int X, int Y) position)
        {
            Color = color;
            Position = position;
        }

        public void Move((int X, int Y) newPosition)
        {
            if (CanMove(newPosition))
            {
                Position = newPosition;
                Console.WriteLine($"Фигура перемещена на {newPosition}");
            }
            else
            {
                Console.WriteLine("Невозможно переместить фигуру на указанную позицию.");
            }
        }

        protected abstract bool CanMove((int X, int Y) newPosition);

        public override string ToString()
        {
            return $"{Color} {GetType().Name} на ({Position.X}, {Position.Y})";
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}