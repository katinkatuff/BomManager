﻿using BomManager.Models;
using BomManager.Services;
using BomManager.ViewModels;

namespace BomManager.Commands;

public class AddPartCommand(IRepository<Part> partsRepository, PartsListViewModel partsListViewModel) : AsyncCommand {
  public override async Task ExecuteAsync(object? parameter) {
    var partViewModel = parameter as PartViewModel;
    ArgumentNullException.ThrowIfNull(nameof(partViewModel));

#pragma warning disable CS8602 // Dereference of a possibly null reference.
    var part = new Part {
      Id = Guid.NewGuid(),
      Name = partViewModel.Name,
      Comment = partViewModel.Comment,
      Url = partViewModel.Url,
      Value = partViewModel.Value,
    };
#pragma warning restore CS8602 // Dereference of a possibly null reference.

    await partsRepository.AddAsync(part);
    await partsRepository.SaveAsync();

    partsListViewModel.Refresh();
  }
}
