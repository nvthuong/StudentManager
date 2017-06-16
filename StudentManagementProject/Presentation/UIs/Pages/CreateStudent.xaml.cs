using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using StudentManagementProject.Data.Clients.Database;
using StudentManagementProject.Domain.Entities;
using Microsoft.Phone.Tasks;

namespace StudentManagementProject.Presentation.UIs.Pages
{
    public partial class CreateStudent : PhoneApplicationPage
    {
        StudentDatabaseCall db = StudentDatabaseCall.getInstance();
        private PhotoChooserTask photoChooserTask;
        private Student student;
        public CreateStudent()
        {
            InitializeComponent();
            student = new Student();
            photoChooserTask = new PhotoChooserTask();
            photoChooserTask.Completed += photoChooserTask_Completed;
        }

        void photoChooserTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                student.ImagePath = e.OriginalFileName;
                System.Windows.Media.Imaging.BitmapImage bmp = new System.Windows.Media.Imaging.BitmapImage();
                bmp.SetSource(e.ChosenPhoto);
                StudentImage.Source = bmp;
            }
        }

        private void CreateStudent_Click(object sender, EventArgs e)
        {
            student.Name = txtFullName.Text;
            student.Address = txtAddress.Text;
            student.Email = txtEmail.Text;
            Boolean hasCreated = db.addStudent(student);
            if (hasCreated)
            {
                Uri path = new Uri("/Presentation/UIs/Pages/MainPage.xaml", UriKind.RelativeOrAbsolute);
                NavigationService.Navigate(path);
            }
            
        }

        private void StudentImage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            photoChooserTask.Show();
        }

        private void btnBack_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            PhoneApplicationFrame frame = Application.Current.RootVisual as PhoneApplicationFrame;
            frame.GoBack();
        }

        private void radioGender_Click(object sender, RoutedEventArgs e)
        {
            student.Gender = radioMale.IsChecked.Value;
        }
    }
}