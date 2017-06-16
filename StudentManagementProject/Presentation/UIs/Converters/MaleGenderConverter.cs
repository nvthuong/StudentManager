using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace StudentManagementProject.Presentation.UIs.Converters
{
    public class MaleGenderConverter : IValueConverter
    {
        
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo language)
        {
            Boolean isMale = (Boolean)value;

            return isMale;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo language)
        { throw new NotImplementedException(); }

    }
}
