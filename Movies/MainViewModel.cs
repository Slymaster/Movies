using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Movies
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Name = "Veuillez vous identifier";
            MyCommand = new RelayCommand(MyCommandExecute, MyCommandCanExecute);
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        public RelayCommand MyCommand { get; } 

        void MyCommandExecute()
        {
            new LogIn();
        }

        bool MyCommandCanExecute()
        {
            return Name!="Bienvenue";
        }
    }
}
