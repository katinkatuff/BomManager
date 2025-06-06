namespace BomManager.ViewModels {
  public class PartViewModel : ViewModel {
    public Guid Id { get; set; }

    private string name = string.Empty;
    public string Name {
      get { return name; }
      set {
        name = value;
        OnPropertyChanged(nameof(Name));
      }
    }

    private string url = string.Empty;
    public string Url {
      get { return url; }
      set {
        url = value;
        OnPropertyChanged(nameof(Url));
      }
    }

    private string _value = string.Empty;
    public string Value {
      get { return _value; }
      set {
        _value = value;
        OnPropertyChanged(nameof(Value));
      }
    }

    private string comment = string.Empty;
    public string Comment {
      get { return comment; }
      set {
        comment = value;
        OnPropertyChanged(nameof(Comment));
      }
    }
  }
}
