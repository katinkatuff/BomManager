using BomManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BomManager.Services;

public class ModuleRepository(ModuleContext context) : IDisposable, IModuleRepository {
  public async Task<IEnumerable<Module>> GetModulesAsync() {
    return await context.Modules.ToListAsync();
  }

  public async Task<Module> GetModuleByIdAsync(Guid id) {
    Module? module = await context.Modules.SingleOrDefaultAsync(module => module.Id == id);
    if (module == null) {
      throw new NullReferenceException(nameof(module));
    }
    return module;
  }

  public async Task<Module> AddModuleAsync(Module module) {
    await context.Modules.AddAsync(module);
    return module;
  }

  public void DeleteModule(Module module) {
    context.Remove(module);
  }

  public Module UpdateModule(Module module) {
    context.Entry(module).State = EntityState.Modified;
    return module;
  }

  public async Task SaveAsync() {
    await context.SaveChangesAsync();
  }

  private bool isDisposed;
  protected virtual void Dispose(bool disposing) {
    if (!this.isDisposed && disposing) {
      context.Dispose();
    }

    this.isDisposed = true;
  }

  public void Dispose() {
    Dispose(true);
    GC.SuppressFinalize(this);
  }
}
