using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPlayground.Model
{
    public enum Priority { Hight, Normal}
    public class SelectorModel
    {
        public string Title { get; set; } = string.Empty;
        public Priority priority { get; set; }
    }
}
