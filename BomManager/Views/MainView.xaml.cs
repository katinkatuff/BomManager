using BomManager.ViewModels;
using System.Windows;

namespace BomManager.Views;

public partial class MainView : Window {
  public MainView(MainViewModel mainViewModel) {
    InitializeComponent();
    DataContext = mainViewModel;
  }
}
