using BomManager.Services;
using BomManager.Views;

namespace BomManager.Commands {
  public class ShowPartDetailViewCommand(INavigationService navigationService) : AsyncCommand {
    public override async Task ExecuteAsync(object? parameter) {
      await navigationService.ShowDialogAsync<PartDetailView>();
    }
  }
}
