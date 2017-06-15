using StudentManagementProject.Domain.Entities;
using StudentManagementProject.Domain.Usecases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementProject.Presentation.Presenters
{
    public class RegisterPresenter : UserPresenter
    {
        public RegisterPresenter(UserViewSurface RegisterViewSurface) : base(RegisterViewSurface)
        {

        }

        public override void excecuteUserInfo(User user)
        {
            GeneralUserUseCase loginUseCase = new RegisterUseCase(this);
            loginUseCase.process(user);
        }
    }
}
