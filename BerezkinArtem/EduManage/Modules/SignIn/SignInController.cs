using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduManage.Services.User;
using EduManage.Shared;

namespace EduManage.Modules.SignIn
{
    public class SignInController
    {
        UserService _userService;
        Context _context;
        public SignInController(UserService userService, Context context)
        {
            _userService = userService;
            _context = context;
        }

        public void SignIn(TextBox loginBox, TextBox passwordBox)
        {
            if (string.IsNullOrEmpty(loginBox.Text) || string.IsNullOrEmpty(passwordBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            var user = _userService.SignIn(loginBox.Text, passwordBox.Text);

            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль!");
            } else
            {
                _context.User = user;
                MessageBox.Show("Успешный вход!");
            }

        }
    }
}
