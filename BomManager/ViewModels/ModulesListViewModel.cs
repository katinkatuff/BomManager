using BomManager.Models;
using BomManager.Services;

namespace BomManager.ViewModels; 

public class ModulesListViewModel : ViewModel {
  private readonly IRepository<Module> moduleRepository;

  public ModulesListViewModel(IRepository<Module> moduleRepository) {
    this.moduleRepository = moduleRepository;
  }
}
