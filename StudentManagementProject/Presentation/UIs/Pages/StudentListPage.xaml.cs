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
using StudentManagementProject.Domain.Entities;
using System.IO.IsolatedStorage;
using System.IO;
using StudentManagementProject.Data.Clients.Database;

namespace StudentManagementProject.Presentation.UIs.Pages
{
    public partial class StudentListPage : PhoneApplicationPage, StudentSearchViewModel.StudentPageViewSurface
    {
        StudentSearchViewModel studentSearchViewModel = null;
        Student student;

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
            NoResult.Height = 50;
            StudentL.ItemsSource.Clear();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            NoResult.Height = 0;

            TextBox value = sender as TextBox;

            studentSearchViewModel.queryStudent(value.Text);
        }

        private void Grid_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
        }

        private void LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LongListSelector select = sender as LongListSelector;
            student  = select.SelectedItem as Student;
            Uri path = new Uri("/Presentation/UIs/Pages/ModifyStudent.xaml", UriKind.RelativeOrAbsolute);
            NavigationService.Navigate(path);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            // NavigationEventArgs returns destination page
            ModifyStudent destinationPage = e.Content as ModifyStudent;
            if (destinationPage != null)
            {
                // Change property of destination page
                destinationPage.setDataContext(student);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            studentSearchViewModel.queryStudent(Search.Text);
        }

    }
}