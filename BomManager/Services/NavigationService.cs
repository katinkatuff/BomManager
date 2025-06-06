using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace BomManager.Services;

public class NavigationService(IServiceProvider serviceProvider) : INavigationService {
  public async Task ShowAsync<T>(object? parameter = null) where T : Window {
    var window = serviceProvider.GetRequiredService<T>();
    if (window is IActivable activableWindow) {
      await activableWindow.ActivateAsync(parameter);
    }

    window.Show();
  }

  public async Task<bool?> ShowDialogAsync<T>(object? parameter = null) where T : Window {
    var window = serviceProvider.GetRequiredService<T>();
    if (window is IActivable activableWindow) {
      await activableWindow.ActivateAsync(parameter);
    }

    return window.ShowDialog();
  }
}
