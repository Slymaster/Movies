using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;

namespace Movies
{
    public class LogInViewModel : ViewModelBase
    {
        private string _name;
        private string _password;

        public LogInViewModel()
        {
            MyCommandRegister = new RelayCommand(MyCommandExecuteRegister, true);
            MyCommandConnect = new RelayCommand(MyCommandExecuteConnect, true);
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

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged();
            }
        }


        public RelayCommand MyCommandRegister { get; }
        public RelayCommand MyCommandConnect { get; }


        void MyCommandExecuteRegister()
        {
            Registration toto = new Registration();
            toto.ShowDialog();
        }

        void MyCommandExecuteConnect()
        {
            if (Name != null)
                if (Name.Equals("toto"))
                    MessageBox.Show("Good, " + Name + "!");
                else
                    MessageBox.Show("Sorry. You cannot access this page.");
        }

        bool MyCommandCanExecute()
        {
            return true;
        }

    }
}