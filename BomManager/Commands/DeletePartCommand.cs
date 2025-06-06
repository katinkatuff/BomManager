using BomManager.Models;
using BomManager.Services;
using BomManager.ViewModels;

namespace BomManager.Commands;

internal class DeletePartCommand(IRepository<Part> partsRepository, PartsListViewModel partsListViewModel) : AsyncCommand {
  public override async Task ExecuteAsync(object? parameter) {
    if (parameter is Part part) { 
      partsRepository.Delete(part);
      await partsRepository.SaveAsync();
      partsListViewModel.Refresh();
    }
  }

  public override bool CanExecute(object? parameter) {
    if (parameter is Part part) {
      return part != null;
    }

    return false;
  }
}
