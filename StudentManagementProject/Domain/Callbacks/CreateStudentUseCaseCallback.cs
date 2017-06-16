using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementProject.Domain.Callbacks
{
    public interface CreateStudentUseCaseCallback
    {
        void notifySuccess();
        void notifyFail();
    }
}
