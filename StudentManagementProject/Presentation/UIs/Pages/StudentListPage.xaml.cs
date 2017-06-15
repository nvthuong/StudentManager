using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using StudentManagementProject.Presentation.UIs.ViewModels;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace StudentManagementProject.Presentation.UIs.Pages
{
    public partial class StudentListPage : PhoneApplicationPage, StudentSearchViewModel.StudentPageViewSurface
    {

        StudentSearchViewModel studentSearchViewModel = null;

        public StudentSearchViewModel StudentSearchViewModel
        {
            get
            {
                if (studentSearchViewModel == null)
                {
                    studentSearchViewModel = new StudentSearchViewModel(this);
                    studentSearchViewModel.queryStudent("");
                }
                return studentSearchViewModel;
            }
        }

        public StudentListPage()
        {
            InitializeComponent();
            LayoutRoot.DataContext = StudentSearchViewModel;   
        }

        public void onQueryFail()
        {
            MessageBox.Show("Can't find any result");
        }

    }
}