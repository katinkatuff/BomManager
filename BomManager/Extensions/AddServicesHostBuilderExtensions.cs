﻿using BomManager.Models;
using BomManager.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BomManager.Extensions;

public static class AddServicesHostBuilderExtensions {
  public static IHostBuilder AddServices(this IHostBuilder hostBuilder) {
    hostBuilder.ConfigureServices(services => {
      services.AddDbContext<ModuleContext>();
      services.AddSingleton<INavigationService, NavigationService>();
      services.AddScoped<IRepository<Module>, ModuleRepository>();
      services.AddScoped<IRepository<Part>, PartRepository>();
    });

    return hostBuilder;
  }
}
