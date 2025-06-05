using BomManager.ViewModels;
using System.Windows.Controls;

namespace BomManager.Views; 

public partial class MenuView : UserControl {
  public MenuView(MenuViewModel menuViewModel) {
    InitializeComponent();
    DataContext = menuViewModel;
  }
}
