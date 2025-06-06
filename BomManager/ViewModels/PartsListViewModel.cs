using BomManager.Commands;
using BomManager.Models;
using BomManager.Services;
using System.Windows.Input;

namespace BomManager.ViewModels;

public class PartsListViewModel : ViewModel {
  private readonly IRepository<Part> partsRepository;

  public NotifyTaskCompletion<IEnumerable<Part>> GetPartsTask { get; }

  public ICommand AddPartCommand { get; }
  
  public PartsListViewModel(IRepository<Part> partsRepository, INavigationService navigationService) {
    this.partsRepository = partsRepository;
    GetPartsTask = new NotifyTaskCompletion<IEnumerable<Part>>(partsRepository.GetAsync());
    AddPartCommand = new ShowPartDetailViewCommand(navigationService);
  }
}
