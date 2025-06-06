using BomManager.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BomManager.Extensions;

public static class AddViewModelsHostExtensions {
  public static IHostBuilder AddViewModels(this IHostBuilder hostBuilder) {
    hostBuilder.ConfigureServices(services => {
      services.AddSingleton<MainViewModel>();
      services.AddSingleton<MenuViewModel>();
      services.AddSingleton<ModulesListViewModel>();
      services.AddSingleton<PartsListViewModel>();
      services.AddTransient<PartDetailViewModel>();
    });

    return hostBuilder;
  }
}
