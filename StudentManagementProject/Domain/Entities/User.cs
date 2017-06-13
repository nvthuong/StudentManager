using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace StudentManagementProject.Domain.Entities
{
    public class User
    {
        private String email;
        private String password;
        private String fullname;
        private String imgPath;
        // True is male, false is female
        private Boolean gender;

        [PrimaryKey]
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }

        public String ImgPath
        {
            get { return imgPath; }
            set { imgPath = value; }
        }

        public Boolean Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public User(String email, String pass, String fname, String imgPath, bool gender)
        {
            this.email = email;
            this.password = pass;
            this.fullname = fname;
            this.imgPath = imgPath;
            this.gender = gender;
        }

        public User()
        {
            this.email = "";
            this.password = "";
            this.fullname = "";
            this.imgPath = "";
            this.gender = true;
        }

    }
}
