using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Windows.ApplicationModel.Core;
using Windows.Storage.Pickers;
using Windows.Foundation;
using Windows.Storage;
using StudentManagementProject.Domain.Entities;
using StudentManagementProject.Presentation.Presenters;
using StudentManagementProject.Presentation.Systems;
using Microsoft.Phone.Tasks;

namespace StudentManagementProject.Presentation.UIs.Pages
{
    public partial class RegisPage : PhoneApplicationPage, LoginPresenter.UserViewSurface
    {
        private PhotoChooserTask photoChooserTask;
        private User addedUser;
        private UserPresenter userPresenter;

        public RegisPage()
        {
            InitializeComponent();
            userPresenter = new RegisterPresenter(this);
            // Init new added user
            addedUser = new User();

            photoChooserTask = new PhotoChooserTask();
            photoChooserTask.Completed += photoChooserTask_Completed;
        }

        void photoChooserTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                addedUser.ImgPath = e.OriginalFileName;
                System.Windows.Media.Imaging.BitmapImage bmp = new System.Windows.Media.Imaging.BitmapImage();
                bmp.SetSource(e.ChosenPhoto);
                UserImage.Source = bmp;
            }
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            addedUser.Gender = rdioMale.IsChecked.Value;
        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            photoChooserTask.Show();
        }

        private void txtUserNameRegis_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUserNameRegis.Text == "username")
            {
                txtUserNameRegis.Text = "";
            }
        }

        private void txtUserNameRegis_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtUserNameRegis.Text == "")
            {
                txtUserNameRegis.Text = "username";
            }
        }

        private void txtFullNameRegis_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtFullNameRegis.Text == "fullname")
            {
                txtFullNameRegis.Text = "";
            }
        }

        private void txtFullNameRegis_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtFullNameRegis.Text == "")
            {
                txtFullNameRegis.Text = "full name";
            }
        }

        private void txtPasswordRegis_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtPasswordRegis.Password == "password")
            {
                txtPasswordRegis.Password = "";
            }
        }

        private void txtPasswordRegis_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtPasswordRegis.Password == "")
            {
                txtPasswordRegis.Password = "password";
            }
        }

        private void txtRePasswordRegis_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtRePasswordRegis.Password == "retype password")
            {
                txtRePasswordRegis.Password = "";
            }
        }

        private void txtRePasswordRegis_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtRePasswordRegis.Password == "")
            {
                txtRePasswordRegis.Password = "retype password";
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            addedUser.Email = txtUserNameRegis.Text;
            addedUser.Password = txtPasswordRegis.Password;
            addedUser.Fullname = txtFullNameRegis.Text;
            addedUser.Gender = rdioMale.IsChecked.Value;

            if (CheckInputUtils.checkEmail(addedUser.Email))
            {
                if (CheckInputUtils.checkPassword(addedUser.Password))
                {
                    userPresenter.excecuteUserInfo(addedUser);
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

        public void onUserAccessFailed()
        {
            ToastMaker.makeShortNoti("Can not register", "Please try again later");
        }

        public void onUserAccessSuccess(User user)
        {
            addedUser = user;
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
                destinationPage.User = addedUser;
            }
        }

    }
}