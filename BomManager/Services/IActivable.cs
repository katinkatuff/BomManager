namespace BomManager.Services;

public interface IActivable {
  Task ActivateAsync(object? parameter);
}
