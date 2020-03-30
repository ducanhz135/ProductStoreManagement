﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProductStoreManagement.ViewModel
{
    public class MainViewModel: BaseViewModel
    {
        public MainViewModel()
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
        } 
    }
}
