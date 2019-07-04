using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Movies
{
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand MyCommand { get; }

        private string _name;

        public Action CloseAction { get; set; }


        public MainViewModel()
        {
            Name = "Veuillez vous identifier";
            MyCommand = new RelayCommand(MyCommandExecute, MyCommandCanExecute);
        }


        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        void MyCommandExecute()
        {
            LogIn toto = new LogIn();
            CloseAction();
            toto.ShowDialog();

        }


        bool MyCommandCanExecute()
        {
            return true;
        }
    }
}
