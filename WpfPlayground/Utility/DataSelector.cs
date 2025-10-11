using System;
using System.Windows;
using System.Windows.Controls;
using WpfPlayground.Model;

namespace WpfPlayground.Utility
{
    public class TaskTemplateSelector: DataTemplateSelector
    {
        public DataTemplate NormalTemplate { get; set; }
        public DataTemplate HighTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if(item is SelectorModel t)
            {
                return t.priority == Priority.Hight ? HighTemplate : NormalTemplate;
            }

            return base.SelectTemplate(item, container);
        }


    }
}
