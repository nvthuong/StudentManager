using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using Windows.Storage;

namespace StudentManagementProject.Presentation.UIs.Converters
{
    public class PathToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo language)
        {
            String path = (String)value;

            // the below class you will find in Stephen's answer mentioned above
            BitmapImage image = new BitmapImage(new Uri(path));

            return image;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo language)
        { throw new NotImplementedException(); }

    }
}
