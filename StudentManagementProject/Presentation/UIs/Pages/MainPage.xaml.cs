using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using StudentManagementProject.Domain.Entities;
using StudentManagementProject.Presentation.UIs.ViewModels;

namespace StudentManagementProject.Presentation.UIs.Pages
{
    public partial class MainPage : PhoneApplicationPage
    {

        private User user = new User()
        {
            Fullname = "Nguyen Anh Huy",
            Email = "nguyenhuy3588@gmail.com",
            ImgPath = "",
            Gender = true,
        };

        private StudentSearchViewModel studentVM;

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public MainPage()
        {
            InitializeComponent();
            DrawerLayout.InitializeDrawerLayout();
            FullName.DataContext = user;
        }

        private void DrawerIcon_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (DrawerLayout.IsDrawerOpen)
                DrawerLayout.CloseDrawer();
            else
                DrawerLayout.OpenDrawer();
        }

        private void ListStudent_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri path = new Uri("/Presentation/UIs/Pages/StudentListPage.xaml", UriKind.RelativeOrAbsolute);
            NavigationService.Navigate(path);
        }

    }
}