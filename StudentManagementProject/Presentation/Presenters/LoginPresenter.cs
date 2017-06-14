using StudentManagementProject.Domain.Entities;
using StudentManagementProject.Domain.Usecases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementProject.Presentation.Presenters
{
    public class LoginPresenter : UserPresenter
    {
        public LoginPresenter(UserViewSurface LoginViewSurface) : base(LoginViewSurface)
        {

        }

        public override void excecuteUserInfo(User user)
        {
            GeneralUserUseCase loginUseCase = new LoginUseCase(this);
            loginUseCase.process(user);
        }
    }
}
