using System.Windows;

namespace BomManager.Services {
  public interface INavigationService {
    Task ShowAsync<T>(object? parameter = null) where T : Window;
    Task<bool?> ShowDialogAsync<T>(object? parameter = null) where T : Window;
  }
}