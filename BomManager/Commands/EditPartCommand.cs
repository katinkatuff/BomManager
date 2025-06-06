using BomManager.Models;
using BomManager.Services;
using BomManager.ViewModels;

namespace BomManager.Commands;

public class EditPartCommand(IRepository<Part> partsRepository, PartsListViewModel partsListViewModel) : AsyncCommand {
  public override async Task ExecuteAsync(object? parameter) {
    var partViewModel = parameter as PartViewModel;
    ArgumentNullException.ThrowIfNull(partViewModel, nameof(partViewModel));

    var part = new Part {
      Id = partViewModel.Id,
      Name = partViewModel.Name,
      Comment = partViewModel.Comment,
      Url = partViewModel.Url,
      Value = partViewModel.Value,
    };

    partsRepository.Update(part);
    await partsRepository.SaveAsync();

    partsListViewModel.Refresh();
  }
}
