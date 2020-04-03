using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProductStoreManagement.ViewModel
{
    public class ProductViewModel : BaseViewModel
    {

        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }

        private string _SelectedUnit;
        public string SelectedUnit { get => _SelectedUnit; set { _SelectedUnit = value; OnPropertyChanged(); } }

        private string _SelectedSuplier;
        public string SelectedSuplier { get => _SelectedSuplier; set { _SelectedSuplier = value; OnPropertyChanged(); } }
        private bool _Checked;
        public bool Checked { get => _Checked; set { _Checked = value; OnPropertyChanged(); } }
        private string _available;
        public string available { get => _available; set { _available = value; OnPropertyChanged(); } }


        public ICommand AddCommand { get; set; }
        public ICommand RadioButtonCommand { get; set; }

        public ProductViewModel()
        {
            
            RadioButtonCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                var a = p;
            });

            AddCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                var a = available;
            });
        }

    }
}
