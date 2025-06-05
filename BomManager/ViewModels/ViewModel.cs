using System.ComponentModel;

namespace BomManager.ViewModels;

public class ViewModel : INotifyPropertyChanged {
  public event PropertyChangedEventHandler? PropertyChanged;

  public void OnPropertyChanged(string propertyName) {
    ArgumentNullException.ThrowIfNull(propertyName);
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
  }
}
