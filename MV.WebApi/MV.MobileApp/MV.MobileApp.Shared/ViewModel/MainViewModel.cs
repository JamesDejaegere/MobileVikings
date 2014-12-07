using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace MV.MobileApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string _applicationName;

        public string ApplicationName
        {
            get { return _applicationName; }
            set { Set(() => ApplicationName, ref _applicationName, value); }
        }
        public MainViewModel()
        {
            ApplicationName = IsInDesignMode
                ? "Mobile Vikings DESIGN" 
                : "Mobile Vikings";
        }
    }
}
