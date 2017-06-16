using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementProject.Presentation.Presenters
{
   public class StudentPresenter
    {
       public interface CreateStudentViewSurface
       {
           void notify(bool result);
       }
    }
}
