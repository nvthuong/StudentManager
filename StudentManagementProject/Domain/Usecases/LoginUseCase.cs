using StudentManagementProject.Data.Managers;
using StudentManagementProject.Domain.Callbacks;
using StudentManagementProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementProject.Domain.Usecases
{
    public class LoginUseCase : GeneralUserUseCase
    {
        public LoginUseCase(UserUseCase userUseCase) : base(userUseCase)
        {
            userRepo = new LoginRepositoryImp();
        }
    }
}
