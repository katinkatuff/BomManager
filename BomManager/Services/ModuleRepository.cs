using BomManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BomManager.Services;

public class ModuleRepository(ModuleContext context) : IDisposable, IRepository<Module> {
  public async Task<IEnumerable<Module>> GetAsync() {
    return await context.Modules.ToListAsync();
  }

  public async Task<Module> GetByIdAsync(Guid id) {
    Module? module = await context.Modules.SingleOrDefaultAsync(module => module.Id == id);
    if (module == null) {
      throw new NullReferenceException(nameof(module));
    }
    return module;
  }

  public async Task<Module> AddAsync(Module item) {
    await context.Modules.AddAsync(item);
    return item;
  }

  public void Delete(Module item) {
    context.Modules.Remove(item);
  }

  public Module Update(Module item) {
    var entity = context.Modules.Find(item.Id);
    ArgumentNullException.ThrowIfNull(entity, nameof(item));
    
    context.Entry(entity).CurrentValues.SetValues(item);
    
    return item;
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
