using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WpfPlayground.Model;

namespace WpfPlayground.ViewModel
{
    public class DataTempViewModel
    {
        public ObservableCollection<Person> People { get; set; }

        public DataTempViewModel()
        {
            People = new ObservableCollection<Person>()
            {
                new Person() { Name = "한준희", Age = "36", NickName = "junhee" },
                new Person() { Name = "심한솔", Age = "35", NickName = "Hansol" },
                new Person() { Name = "한지훈", Age = "4", NickName = "JiHoon" }
            };
        }
    }
}
