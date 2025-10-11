using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPlayground.ViewModel
{
    public class STringMultiConverterViewModel : INotifyPropertyChanged
    {
        string _firstName = "First";
        string _lastName = "Last";

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstName)));
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastName)));
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
