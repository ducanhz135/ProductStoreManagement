using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStoreManagement.Model
{
    public class UserModel: BaseModel
    {
        
        private string _UserName;
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }
        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }
        public UserModel()
        {
            this.UserName = string.Empty;
            this._Password = string.Empty;
        }
    }
}
