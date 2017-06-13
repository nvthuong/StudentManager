using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace StudentManagementProject.Domain.Entities
{
    public class Class
    {
        private String name;

        [PrimaryKey]
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

        public Class(String name)
        {
            this.name = name;
        }

        public Class()
        {
            this.name = "";
        }
    }
}
