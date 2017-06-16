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
    public partial class ModifyStudent : PhoneApplicationPage
    {

        private Student student;

        public Student Student
        {
            get { return student; }
            set { student = value; }
        }

        public ModifyStudent()
        {
            InitializeComponent();
        }

        public void setDataContext(Student student)
        {
            this.student = student;
            StudentInfo.DataContext = this.student;
            if (student.Gender)
            {
                radioMale.IsChecked = true;
            }
            else
            {
                radioFemale.IsChecked = true;
            }
        }
    }
}