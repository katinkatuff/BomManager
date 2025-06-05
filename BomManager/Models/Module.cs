namespace BomManager.Models;

public class Module {
  public Guid Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public string Notes { get; set; } = string.Empty;
  public string Url { get; set; } = string.Empty;
  public List<Part> BillOfMaterials { get; set; } = [];
}
