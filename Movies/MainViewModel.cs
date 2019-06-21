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
        public LogInViewModel ViewModelBase { get; private set; }

        void MyCommandExecute()
        {
            //change view
            ViewModelBase = new LogInViewModel();
        }

        bool MyCommandCanExecute()
        {
            return true;
        }
    }
}
