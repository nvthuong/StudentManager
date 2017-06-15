using StudentManagementProject.Domain.Callbacks;
using StudentManagementProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementProject.Presentation.Presenters
{
    public abstract class UserPresenter : UserUseCase
    {
        protected UserViewSurface userViewSurface;

        public UserPresenter(UserViewSurface userViewSurface)
        {
            this.userViewSurface = userViewSurface;
        }

        public abstract void excecuteUserInfo(User user);

        public void notifyUiToLogin(User user)
        {
            this.userViewSurface.onUserAccessSuccess(user);
        }

        public void notifyUiGiveError()
        {
            this.userViewSurface.onUserAccessFailed();
        }

        public interface UserViewSurface
        {
            void onUserAccessFailed();
            void onUserAccessSuccess(User user);
        }

    }
}
