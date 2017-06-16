using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Tasks;
using Windows.Storage;
using Microsoft.Xna.Framework.Media;
using Microsoft.Phone;

namespace StudentManagementProject.Presentation.UIs.Converters
{
    public class PathToImageConverter : IValueConverter
    {
        private static readonly StorageFolder localFolder = ApplicationData.Current.LocalFolder;

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo language)
        {
            WriteableBitmap bm = null;

            String path = (String)value;

            MediaLibrary media = new MediaLibrary();
            var picture = media.Pictures.FirstOrDefault(p => p.Name.Contains(Path.GetFileName(path)));
            
            if (picture != null)
            {
                // Picture found 
                bm = PictureDecoder.DecodeJpeg(picture.GetImage());
            }

            return bm;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo language)
        { throw new NotImplementedException(); }

    }
}
