using StudentManagementProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementProject.Domain.Callbacks
{
    public interface UserUseCase
    {
        void notifyUiToLogin(User user);
        void notifyUiGiveError();
    }
}
