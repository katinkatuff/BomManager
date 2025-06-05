namespace BomManager.Models;

public class Part {
  public Guid Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public string Url { get; set; } = string.Empty;
  public string Value { get; set; } = string.Empty;
  public string Comment { get; set; } = string.Empty;
  public int Quantity { get; set; }
}
