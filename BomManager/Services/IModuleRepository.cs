using BomManager.Models;

namespace BomManager.Services {
  public interface IModuleRepository {
    Task<Module> AddModuleAsync(Module module);
    void DeleteModule(Module module);
    Task<Module> GetModuleByIdAsync(Guid id);
    Task<IEnumerable<Module>> GetModulesAsync();
    Task SaveAsync();
    Module UpdateModule(Module module);
  }
}