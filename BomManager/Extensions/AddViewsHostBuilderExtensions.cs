using BomManager.Services;
using BomManager.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BomManager.Extensions;

public static class AddViewsHostBuilderExtensions {
  public static IHostBuilder AddViews(this IHostBuilder hostBuilder) {
    hostBuilder.ConfigureServices(services => {
      services.AddSingleton<MainView>();
      services.AddSingleton<MenuView>();
      services.AddSingleton<ModulesListView>();
      services.AddSingleton<PartsListView>();
      services.AddTransient<PartDetailView>();
    });
    return hostBuilder;
  }
}
