namespace BomManager.Commands;

public class ExitCommand : Command {
  public override void Execute(object? parameter) {
    App.Current.Shutdown();
  }
}
