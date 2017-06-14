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

namespace StudentManagementProject.Presentation.UIs.Pages
{
    public partial class MainPage : PhoneApplicationPage
    {

        private User user;

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void DrawerIcon_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (DrawerLayout.IsDrawerOpen)
                DrawerLayout.CloseDrawer();
            else
                DrawerLayout.OpenDrawer();
        }

    }
}