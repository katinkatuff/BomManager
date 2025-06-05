using BomManager.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace BomManager;

public class ModuleContext : DbContext {
  public DbSet<Module> Modules { get; set; }
  public DbSet<Part> Parts { get; set; }

  public string DatabasePath { get; set; }

  public ModuleContext() {
    var folder = Environment.SpecialFolder.LocalApplicationData;
    var path = Environment.GetFolderPath(folder);
    DatabasePath = Path.Join(path, "niamph.db");
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
    optionsBuilder.UseSqlite($"DataSource={DatabasePath}");
  }
}
