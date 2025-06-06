using BomManager.Commands;
using BomManager.Models;
using BomManager.Services;
using System.Windows.Input;

namespace BomManager.ViewModels;

public class PartsListViewModel : ViewModel {
  private readonly IRepository<Part> partsRepository;

  public PartsListViewModel(IRepository<Part> partsRepository, INavigationService navigationService) {
    AddPartCommand = new ShowPartDetailViewCommand(navigationService);
    EditPartCommand = new ShowPartDetailViewCommand(navigationService);
    DeletePartCommand = new DeletePartCommand(partsRepository, this);
    this.partsRepository = partsRepository;
    getPartsTask = new(partsRepository.GetAsync());
  }


  private NotifyTaskCompletion<IEnumerable<Part>> getPartsTask;
  public NotifyTaskCompletion<IEnumerable<Part>> GetPartsTask {
    get { return getPartsTask; }
    private set {
      getPartsTask = value;
      OnPropertyChanged(nameof(GetPartsTask));
    }
  }

  private Part? selectedPart = null;
  public Part? SelectedPart {
    get { return selectedPart; }
    set {
      selectedPart = value;
      OnPropertyChanged(nameof(SelectedPart));
      OnPropertyChanged(nameof(IsEditEnabled));
    }
  }

  public bool IsEditEnabled { get { return selectedPart != null; } }

  public ICommand AddPartCommand { get; }
  public ICommand EditPartCommand { get; }
  public ICommand DeletePartCommand { get; }

  public void Refresh() {
    GetPartsTask = new NotifyTaskCompletion<IEnumerable<Part>>(partsRepository.GetAsync());
  }
}
