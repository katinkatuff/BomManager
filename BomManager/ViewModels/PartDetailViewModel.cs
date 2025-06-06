using BomManager.Commands;
using BomManager.Models;
using BomManager.Services;
using System.Windows.Input;

namespace BomManager.ViewModels;

public class PartDetailViewModel(IRepository<Part> partsRepository, PartsListViewModel partsListViewModel) : ViewModel {
  public ICommand? OkCommand { get; private set; }

  public void SetToAddCommand() {
    OkCommand = new AddPartCommand(partsRepository, partsListViewModel);
  }

  public void SetToEditCommand() {
    OkCommand = new EditPartCommand(partsRepository, partsListViewModel);
  }
  
  private PartViewModel part = new();
  public PartViewModel Part {
    get { return part; }
    set { part = value; OnPropertyChanged(nameof(Part)); }
  }

  private string okButtonText = string.Empty;

  public string OkButtonText {
    get { return okButtonText; }
    set {
      okButtonText = value;
      OnPropertyChanged(nameof(OkButtonText));
    }
  }
}