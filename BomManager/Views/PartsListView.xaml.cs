using BomManager.ViewModels;
using System.Windows.Controls;

namespace BomManager.Views;

public partial class PartsListView : UserControl {
  public PartsListView(PartsListViewModel partsListViewModel) {
    InitializeComponent();
    DataContext = partsListViewModel;
  }
}
