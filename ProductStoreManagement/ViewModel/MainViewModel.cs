using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProductStoreManagement.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool Isloaded = false;
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand UnitCommand { get; set; }
        public ICommand SuplierCommand { get; set; }
        public ICommand ProductCommand { get; set; }
        public ICommand UserCommand { get; set; }
        public ICommand InputCommand { get; set; }
        public ICommand OutputCommand { get; set; }

        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                Isloaded = true;
                if (p == null)
                    return;
                p.Hide();
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();

                if (loginWindow.DataContext == null)
                    return;
                var loginVM = loginWindow.DataContext as LoginViewModel;

                if (loginVM.IsLogin)
                {
                    p.Show();
                }
                else
                {
                    p.Close();
                }
            });

            UnitCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                new UnitWindow().ShowDialog();
            });

            SuplierCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                new SupplierWindow().ShowDialog();
            });

            ProductCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                new ProductWindow().ShowDialog();
            });

            UserCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                new UserWindow().ShowDialog();
            });

            InputCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                new InputWindow().ShowDialog();
            });

            OutputCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                new OutputWindow().ShowDialog();
            });

            //LoginWindow loginWindow = new LoginWindow();
            //loginWindow.ShowDialog();
        }
    }
}
