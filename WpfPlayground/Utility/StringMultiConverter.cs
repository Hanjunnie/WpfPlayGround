using DevExpress.Xpf.Core.Native;
using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfPlayground.Utility
{
    class StringMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string first = values[0]?.ToString() ?? string.Empty;
            string second = values[1]?.ToString() ?? string.Empty;

            return $"{first} {second}";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            var str = (value as string)?.Split(' ');
            if (str == null || str.Length != 2)
                return new object[] { "", "" };

            return new object[] { str[0], str[1] };


        }
    }
}
