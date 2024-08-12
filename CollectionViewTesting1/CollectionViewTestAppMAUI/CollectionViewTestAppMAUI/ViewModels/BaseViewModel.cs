using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CollectionViewTestAppMAUI.ViewModels;

public class BaseViewModel : INotifyPropertyChanged
{
        
    bool isRefreshing = false;
    public bool IsRefreshing
    {
        get { return isRefreshing; }
        set
        {
            SetProperty(ref isRefreshing, value);
            IsBusy = isRefreshing;
        }
    }

    bool isBusy = false;
    public bool IsBusy
    {
        get { return isBusy; }
        set
        {
            SetProperty(ref isBusy, value);
            IsNotBusy = !isBusy;
        }
    }

    bool isNotBusy = true;
    public bool IsNotBusy
    {
        get { return isNotBusy; }
        set { SetProperty(ref isNotBusy, value); }
    }
    
    string title = string.Empty;
    public string Title
    {
        get { return title; }
        set { SetProperty(ref title, value); }
    }
    
    
    protected bool SetProperty<T>(ref T backingStore, T value,
        [CallerMemberName] string propertyName = "",
        Action onChanged = null)
    {
        if (EqualityComparer<T>.Default.Equals(backingStore, value))
            return false;

        backingStore = value;
        onChanged?.Invoke();
        OnPropertyChanged(propertyName);
        return true;
    }

    #region INotifyPropertyChanged
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        var changed = PropertyChanged;
        if (changed == null)
            return;

        changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion

    ~BaseViewModel()
    {
        var type = this.GetType();
        Debug.WriteLine($"Garbage Collector cleaned up {type} viewmodel.");
    }
}