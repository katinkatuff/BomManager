using BomManager.Commands;
using BomManager.Models;
using BomManager.Services;
using System.Windows.Input;

namespace BomManager.ViewModels;

public class PartDetailViewModel : ViewModel {
  public PartDetailViewModel(IRepository<Part> partsRepository) {
    AddPartCommand = new AddPartCommand(partsRepository);
  }

  public ICommand AddPartCommand { get; }

  private PartViewModel part = new();
  public PartViewModel Part {
    get { return part; }
    set { part = value; OnPropertyChanged(nameof(Part)); }
  }
}