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
                new Queen(ChessColor.White, (0, 0)),
                new Rook(ChessColor.Black, (7, 7)),
                new Bishop(ChessColor.White, (2, 2))
            };
        }
    }
}