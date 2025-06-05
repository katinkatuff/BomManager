using BomManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BomManager.Services {
  public class PartRepository(ModuleContext context) {

    public async Task<IEnumerable<Part>> GetPartsAsync() {
      return await context.Parts.ToListAsync();
    }
  }
}
