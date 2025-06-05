namespace BomManager.Commands;

public abstract class AsyncCommand : Command {
  private bool isExecuting;
  public bool IsExecuting {
    get { return isExecuting; }
    set {
      isExecuting = value;
      OnCanExecuteChanged();
    }
  }

  public override bool CanExecute(object? parameter) {
    return !isExecuting && base.CanExecute(parameter);
  }

  public override async void Execute(object? parameter) {
    IsExecuting = true;

    try {
      await ExecuteAsync(parameter);
    } finally {
      IsExecuting = false;
    }
  }

  public abstract Task ExecuteAsync(object? parameter);
}
