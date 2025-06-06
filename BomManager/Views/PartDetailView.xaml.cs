using BomManager.Models;
using BomManager.Services;
using BomManager.ViewModels;
using System.Windows;

namespace BomManager.Views;

public partial class PartDetailView : Window, IActivable {
  public PartDetailView(PartDetailViewModel partDetailViewModel) {
    InitializeComponent();
    DataContext = partDetailViewModel;
  }

  public Task ActivateAsync(object? parameter) {
    if (parameter is string okButtonText) {
      var viewModel = (PartDetailViewModel)DataContext;
      okButton.Content = okButtonText;
      Title = $"{okButtonText} part";

      viewModel.SetToAddCommand();
    }

    if (parameter is Part selectedPart) {
      var viewModel = (PartDetailViewModel)DataContext;
      viewModel.Part = new PartViewModel {
        Id = selectedPart.Id,
        Comment = selectedPart.Comment,
        Name = selectedPart.Name,
        Url = selectedPart.Url,
        Value = selectedPart.Value,
      };

      okButton.Content = "Edit";
      Title = "Edit part";

      viewModel.SetToEditCommand();
    }

    return Task.CompletedTask;
  }

  private void Ok_Click(object sender, RoutedEventArgs e) {
    DialogResult = true;
  }

  private void Cancel_Click(object sender, RoutedEventArgs e) {
    DialogResult = false;
  }
}
