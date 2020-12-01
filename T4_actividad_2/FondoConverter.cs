using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace T4_actividad_2
{
    class FondoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((Boolean)value == true)
            {
                return Brushes.PaleGreen;
            }
            else return Brushes.IndianRed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
