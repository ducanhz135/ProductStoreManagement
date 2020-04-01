using ProductStoreManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProductStoreManagement.ViewModel
{
    public class LoginViewModel: BaseViewModel
    {
        public bool IsLogin { get; set; }

        public UserModel User = new UserModel();
        public string UserName { set { User.UserName = value; } }
        //private string _UserName;
        //public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }
        //private string _Password;
        //public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }


        public ICommand CloseCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }

        public LoginViewModel()
        {
            IsLogin = false;
            //User.Password = string.Empty;
            //User.UserName = string.Empty;
            LoginCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { Login(p); });
            CloseCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { p.Close(); });
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { User.Password = p.Password; });
        }

        void Login(Window p)
        {
            if (p == null)
                return;
            IsLogin = true;

            p.Close();
            //if (User.UserName == "admin" && User.Password == "pass")
            //{
            //    IsLogin = true;

            //    p.Close();
            //}
            //else
            //{
            //    IsLogin = false;
            //    MessageBox.Show("Wrong username and password! " +
            //        "please input username: admin & password: pass");
            //}
        }
    }
}
