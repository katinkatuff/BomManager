using BomManager.ViewModels;
using System.Windows.Controls;

namespace BomManager.Views;

public partial class ModulesListView : UserControl {
  public ModulesListView(ModulesListViewModel modulesListViewModel) {
    InitializeComponent();
    DataContext = modulesListViewModel;
  }
}
