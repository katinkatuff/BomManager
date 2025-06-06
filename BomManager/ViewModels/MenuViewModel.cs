using BomManager.Commands;
using BomManager.Services;
using System.Windows.Input;

namespace BomManager.ViewModels; 

public class MenuViewModel : ViewModel {
  public ICommand SaveCommand { get; }
  public ICommand ExitCommand { get; }
  public ICommand AddModuleCommand { get; }
  public ICommand AddPartCommand { get; }

  public MenuViewModel(INavigationService navigationService) {
    ExitCommand = new ExitCommand();
    AddPartCommand = new ShowPartDetailViewCommand(navigationService);
  }
}
