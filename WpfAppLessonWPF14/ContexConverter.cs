using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfAppLessonWPF14
{
    class ContexConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value switch
            {
                ProductTypes.Food => "ЕДА",
                ProductTypes.Applinces => "Бытовая техника",
                _ => "Неведомая ХРЕНЬ"
            };
        }
        

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((string)value == "ЕДА") return "Food";
            if ((string)value == "Бытовая техника") return "Applinces";
            return DependencyProperty.UnsetValue;
        }
    }
}
