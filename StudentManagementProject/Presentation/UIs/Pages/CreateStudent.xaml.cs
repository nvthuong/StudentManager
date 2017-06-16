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
using StudentManagementProject.Presentation.Presenters;
using System.IO;
using Windows.Storage;
using System.Windows.Media.Imaging;
using System.IO.IsolatedStorage;
using Microsoft.Xna.Framework.Media;

namespace StudentManagementProject.Presentation.UIs.Pages
{
    public partial class CreateStudent : PhoneApplicationPage, StudentManagementProject.Presentation.Presenters.StudentPresenter.CreateStudentViewSurface
    {
        StudentPresenter createStudentPresenter;
        private PhotoChooserTask photoChooserTask;
        private Student student;
        
        public CreateStudent()
        {
            InitializeComponent();
            student = new Student();
            dropClass.Items.Add("Class 1");
            dropClass.Items.Add("Class 2");
            dropClass.Items.Add("Class 3");
            photoChooserTask = new PhotoChooserTask();
            createStudentPresenter = new StudentPresenter(this);
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

        private void loadImage()
        {
            MediaLibrary media = new MediaLibrary();
            var picture = media.Pictures.FirstOrDefault(p => p.Name.Contains(Path.GetFileName(student.ImagePath)));

            if (picture != null)
            {
                // Picture found 
                BitmapImage image = new BitmapImage();
                image.SetSource(picture.GetImage());

                StudentImage.Source = image;
            }
        }

        private void CreateStudent_Click(object sender, EventArgs e)
        {
            student.Name = txtFullName.Text;
            student.Address = txtAddress.Text;
            student.ClassName = dropClass.SelectedItem.ToString();
            student.Email = txtEmail.Text;
            createStudentPresenter.createStudent(student);
        }

        private void StudentImage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            photoChooserTask.Show();
        }

        private void radioGender_Click(object sender, RoutedEventArgs e)
        {
            student.Gender = radioMale.IsChecked.Value;
        }

        private void btnBack_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            PhoneApplicationFrame frame = Application.Current.RootVisual as PhoneApplicationFrame;
            frame.GoBack();
        }

        public void notifySuccess()
        {
            Uri path = new Uri("/Presentation/UIs/Pages/MainPage.xaml", UriKind.RelativeOrAbsolute);
            NavigationService.Navigate(path);
        }

        public void notifyFail()
        {
            MessageBox.Show("Create fail!");
        }

    }

}