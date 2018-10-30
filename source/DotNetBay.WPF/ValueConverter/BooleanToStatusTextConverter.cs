using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DotNetBay.WPF.ValueConverter
{
    public class BooleanToStatusTextConverter : IValueConverter
    {
        //backend -> ui
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool status = (bool)value;

            string statusTxt = status ? "offen" : "geschlossen";

            return statusTxt;
        }

        //from ui -> backend
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string statusTxt = (string)value;

            bool status = "offen".Equals(statusTxt) ? true : false;

            return status;
        }
    }
}

