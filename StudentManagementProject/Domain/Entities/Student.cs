using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace StudentManagementProject.Domain.Entities
{
    public class Student
    {
        private int studentId;
        private String name;
        private String email;
        private String address;
        private String className;
        private String imgPath;
        private Boolean gender;

        [PrimaryKey, AutoIncrement]
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public String Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }


        public String Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        [Indexed]
        public String ClassName
        {
            get
            {
                return className;
            }
            set
            {
                className = value;
            }
        }

        public String ImagePath
        {
            get
            {
                return imgPath;
            }
            set
            {
                imgPath = value;
            }
        }

        public Boolean Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public Student(String name, String email, String address, String className, String imgPath, Boolean gender)
        {
            this.name = name;
            this.email = email;
            this.address = address;
            this.className = className;
            this.imgPath = imgPath;
            this.gender = gender;
        }

        public Student(int id, String name, String className, String imgPath, Boolean gender)
        {
            this.studentId = id;
            this.name = name;
            this.className = className;
            this.imgPath = imgPath;
            this.gender = gender;
        }

        public Student()
        {
            this.name = "Nguyen Van Thuong";
            this.address = "1 To Ky, Cong Vien Phan mem Quang Trung, TMA building";
            this.email = "nvthuong@tma.com.vn";
            this.className = "Class 1";
            this.imgPath = "/Images/avata1.jpg";
            this.gender = true;
        }
    }
}
