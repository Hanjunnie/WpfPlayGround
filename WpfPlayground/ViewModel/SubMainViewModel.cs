using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPlayground.ViewModel
{
    public class SubMainViewModel : INotifyPropertyChanged
    {

        private string _apddress = "Default Address";
        public string Address
        {
            get => _apddress;
            set
            {
                if (_apddress != value)
                {
                    _apddress = value;
                    OnPropertyChanged(Address);
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
