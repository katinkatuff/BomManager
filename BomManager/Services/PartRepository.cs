using BomManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BomManager.Services;

public class PartRepository(ModuleContext context) : IDisposable, IRepository<Part> {
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

  public async Task<Part> AddAsync(Part item) {
    await context.Parts.AddAsync(item);
    return item;
  }

  public void Delete(Part item) {
    context.Parts.Remove(item);
  }

  public async Task<Part> GetByIdAsync(Guid id) {
    Part? part = await context.Parts.SingleOrDefaultAsync(part => part.Id == id);
    if (part == null) {
      throw new NullReferenceException(nameof(part));
    }
    return part;
  }

  public async Task<IEnumerable<Part>> GetAsync() {
    return await context.Parts.ToListAsync();
  }

  public Part Update(Part item) {
    var entity = context.Parts.Find(item.Id);
    ArgumentNullException.ThrowIfNull(entity, nameof(item));
    
    context.Entry(entity).CurrentValues.SetValues(item);
    
    return item;
  }
}
