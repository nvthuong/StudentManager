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
            this.studentId = -1;
            this.name = "";
            this.className = "";
            this.imgPath = "";
            this.gender = true;
        }
    }
}
