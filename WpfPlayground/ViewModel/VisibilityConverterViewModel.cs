using System;
using System.ComponentModel;

namespace WpfPlayground.ViewModel
{
    public class VisibilityConverterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private bool _isVisible = false;
        public bool IsVisibilityLabel
        {
            get => _isVisible;
            set
            {
                if(_isVisible != value)
                {
                    _isVisible = value;
                    OnPropertyChanged(nameof(IsVisibilityLabel));
                }
            }

        }

        public void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
