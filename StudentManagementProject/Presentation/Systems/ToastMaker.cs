using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StudentManagementProject.Presentation.Systems
{
    public class ToastMaker
    {
        public static void makeShortNoti(String title, String msg)
        {
            MessageBox.Show(msg, title, MessageBoxButton.OK);
        }
    }
}
