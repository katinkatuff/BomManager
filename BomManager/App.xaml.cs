using BomManager.Extensions;
using BomManager.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace BomManager;

public partial class App : Application {
  private IHost? host;

  private async void Application_Startup(object sender, StartupEventArgs e) {
    host = Host.CreateDefaultBuilder()
      .AddServices()
      .AddViewModels()
      .AddViews()
      .Build();

    await host.StartAsync();

    MainWindow = host.Services.GetRequiredService<MainView>();
    MainWindow.Show();
  }

  private async void Application_Exit(object sender, ExitEventArgs e) {
    if (host == null) return;

    await host.StopAsync();
    host.Dispose();
  }
}
