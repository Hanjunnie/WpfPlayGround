using System;
using System.Collections.ObjectModel;
using WpfPlayground.Model;

namespace WpfPlayground.ViewModel
{
    public class SelectorViewModel
    {
        public ObservableCollection<SelectorModel> Tasks { get; } =
        new()
        {
            new SelectorModel{Title ="문서 정리", priority = Priority.Normal},
            new SelectorModel{Title ="긴급 버그 수정", priority = Priority.Hight}
        };
    }
}
