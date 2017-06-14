using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using StudentManagementProject.Resources;
using StudentManagementProject.Presentation.Systems;
using StudentManagementProject.Presentation.Presenters;
using StudentManagementProject.Domain.Entities;

namespace StudentManagementProject.Presentation.UIs.Pages
{
    public partial class LoginPage : PhoneApplicationPage, LoginPresenter.UserViewSurface
    {
        private User successUser = null;
        private UserPresenter userPresenter;

        // Constructor
        public LoginPage()
        {
            InitializeComponent();
            userPresenter = new LoginPresenter(this);
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}

        private void initLanguage()
        {

        }

        private void txtUserName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUserName.Text == "username")
            {
                txtUserName.Text = "";
            }
        }

        private void txtPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password == "password")
            {
                txtPassword.Password = "";
            }
        }

        private void navRegis_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri path = new Uri("/Presentation/UIs/Pages/RegisPage.xaml", UriKind.RelativeOrAbsolute);
            NavigationService.Navigate(path);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.Email = txtUserName.Text;
            user.Password = txtPassword.Password;

            if (CheckInputUtils.checkEmail(user.Email))
            {
                if (CheckInputUtils.checkPassword(user.Password))
                {
                    userPresenter.excecuteUserInfo(user);
                }
                else
                {
                    ToastMaker.makeShortNoti("Wrong password format", "Make sure your password length is at least 8 including both character and digit");
                }
            }
            else
            {
                ToastMaker.makeShortNoti("Wrong user name format", "Make sure you email is form: gmail, yahoo or tma and domain name is .com.vn");
            }
        }

        private void txtUserName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "username";
            }
        }

        private void txtPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password == "")
            {
                txtPassword.Password = "password";
            }
        }

        public void onUserAccessFailed()
        {
            ToastMaker.makeShortNoti("Can not login", "Wrong user name or password!");
        }

        public void onUserAccessSuccess(User user)
        {
            successUser = user;
            Uri path = new Uri("/Presentation/UIs/Pages/MainPage.xaml", UriKind.RelativeOrAbsolute);
            NavigationService.Navigate(path);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            // NavigationEventArgs returns destination page
            MainPage destinationPage = e.Content as MainPage;
            if (destinationPage != null)
            {
                // Change property of destination page
                destinationPage.User = successUser;
            }
        }

    }
}