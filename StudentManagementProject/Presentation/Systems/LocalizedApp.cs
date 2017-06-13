using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementProject.Presentation.Systems
{
    public class LocalizedApp
    {
        private String language;
        private String resName;

        public String Language
        {
            get
            { return language; }
            set
            {
                language = value;
            }
        }

        public LocalizedApp()
        {

        }
    }
}
