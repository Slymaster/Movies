using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Movies
{
    public class LogInViewModel : ViewModelBase
    {
        public LogInViewModel()
        {
            Name = "test";
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

    }
}