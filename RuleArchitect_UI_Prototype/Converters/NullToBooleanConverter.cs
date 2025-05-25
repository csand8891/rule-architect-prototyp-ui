using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace RuleArchitect_UI_Prototype.Converters
{
    public class NullToBooleanConverter : IValueConverter
    {
        public bool FalseForNull { get; set; } = true; // True: null -> false. False: null -> true.

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isNull = value == null;
            return FalseForNull ? !isNull : isNull;
        }

        public object ConvertBack(object value, Type target, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
