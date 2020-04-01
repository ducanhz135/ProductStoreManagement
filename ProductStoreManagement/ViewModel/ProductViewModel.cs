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

        public ICommand AddCommand { get; set; }

        public ProductViewModel()
        {
            AddCommand = new RelayCommand<Window>((p) => { return true; }, (p) => {
                var a = SelectedSuplier;
            });
        }

    }
}
