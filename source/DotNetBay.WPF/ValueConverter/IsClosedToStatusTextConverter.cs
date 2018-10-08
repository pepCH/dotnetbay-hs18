using System;
using System.Globalization;
using System.Windows.Data;

namespace DotNetBay.WPF.ValueConverter
{
    public class IsClosedToStatusTextConverter : IValueConverter
    {
        private const string _auctionOpen = "Open";
        private const string _auctionClosed = "Closed";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value is bool && ((bool) value)) ? _auctionClosed : _auctionOpen;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
