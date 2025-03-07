using ChessApp.Models;
using System.Collections.ObjectModel;

namespace ChessApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<ChessPiece> ChessPieces { get; set; }

        public MainWindowViewModel()
        {
            ChessPieces = new ObservableCollection<ChessPiece>
            {
                new Queen("Белый", (0, 0)),
                new Rook("Чёрный", (7, 7)),
                new Bishop("Белый", (2, 2))
            };
        }
    }
}