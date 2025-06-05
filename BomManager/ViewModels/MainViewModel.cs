using BomManager.Views;
using System.Windows.Controls;

namespace BomManager.ViewModels;

public class MainViewModel : ViewModel {
  public UserControl MenuView { get; }
  public UserControl ModulesListView { get; }
  public UserControl PartsListView { get; }

  public MainViewModel(MenuView menuView, ModulesListView modulesListView, PartsListView partsListView) {
    MenuView = menuView;
    ModulesListView = modulesListView;
    PartsListView = partsListView;
  }
}
