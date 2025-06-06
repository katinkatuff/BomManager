using BomManager.Services;
using BomManager.ViewModels;
using System.Windows;

namespace BomManager.Views;

public partial class PartDetailView : Window, IActivable {
  public PartDetailView(PartDetailViewModel addPartViewModel) {
    InitializeComponent();
    DataContext = addPartViewModel;
  }

  public Task ActivateAsync(object? parameter) {
    return Task.CompletedTask;
  }
}
