﻿using BomManager.Models;
using BomManager.Services;
using BomManager.Views;

namespace BomManager.Commands;

public class ShowPartDetailViewCommand(INavigationService navigationService) : AsyncCommand {
  public override async Task ExecuteAsync(object? parameter) {
    await navigationService.ShowDialogAsync<PartDetailView>(parameter);
  }

  public override bool CanExecute(object? parameter) {
    if (parameter is string okButtonText) {
      return okButtonText == "Add";
    }

    if (parameter is Part part) {
      return part != null;
    }

    return false;
  }
}
