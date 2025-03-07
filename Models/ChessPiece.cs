using System;
using System.ComponentModel;

namespace ChessApp.Models
{
    public abstract class ChessPiece : INotifyPropertyChanged
    {
        private ChessColor _color; // Используем enum
        private (int X, int Y) _position = (0, 0); // Инициализация

        public ChessColor Color
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

        // Свойство для получения имени фигуры
        public string Name => GetType().Name;

        protected ChessPiece(ChessColor color, (int X, int Y) position)
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
            return $"{Color} {Name} на ({Position.X}, {Position.Y})";
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}