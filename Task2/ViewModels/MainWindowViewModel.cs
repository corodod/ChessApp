using System.Collections.ObjectModel;
using Task2.Models;

namespace Task2.ViewModels;
using ReactiveUI;

public class MainWindowViewModel : ReactiveObject
{
    private Figure? _selectedItem;

    public Figure? SelectedItem
    {
        get => _selectedItem;
        set => this.RaiseAndSetIfChanged(ref _selectedItem, value);
    }
    private string _errorText;

    public string ErrorText
    {
        get => _errorText;
        set => this.RaiseAndSetIfChanged(ref _errorText, value);
    }
    public ObservableCollection<Figure> Figures { get; set; } = new ObservableCollection<Figure>();
    
    private int _xValue;

    public int XValue
    {
        get => _xValue;
        set => this.RaiseAndSetIfChanged(ref _xValue, value);
    }
    
    private int _yValue;

    public int YValue
    {
        get => _yValue;
        set => this.RaiseAndSetIfChanged(ref _yValue, value);
    }
    
    public MainWindowViewModel()
    {
        Figures.Add(new Bishop(Color.White, new Position(0, 0)));
        Figures.Add(new Queen(Color.Black, new Position(3, 3)));
        Figures.Add(new Rook(Color.White, new Position(4, 5)));
    }

    public void MoveSelected()
    {
        var oldPosition = SelectedItem?.Position;
        SelectedItem?.Move(new Position(XValue, YValue));

        ErrorText = "";
        if (oldPosition.Equals(SelectedItem?.Position))
            ErrorText = "Cant move here";
    }
}