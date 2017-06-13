using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentManagementProject.Presentation.Systems
{
    public class CheckImgPathUtils
    {
        public static Boolean checkImagePathExisted(string imagePath)
        {
            // Check exist
            if (File.Exists(imagePath))
            {
                return true;
            }
            return false;
        }

        public static Boolean checkImagePathSupportedExtension(String imagePath)
        {
            String ext = Path.GetExtension(imagePath);
            if (ext == ".jpg" || ext == ".png")
            {
                return true;
            }
            return false;
        }
    }
}
