﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Movies
{
    class RegistrationViewModel : ViewModelBase
    {

        private string _name;
        /*        private string _password;*/
        private string _email;

        public RegistrationViewModel()
        {
            TryRegistration = new RelayCommand(Try, true);

        }

/*        public void Execute(object parameter)
        {
            var passwordBox = parameter as PasswordBox;
            var password = passwordBox.Password;

            if (password == "toto")
            {
                MessageBox.Show("good");
            }
            else
            {
                MessageBox.Show("not good");

            }
        }*/

/*        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged();
            }
        }*/

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }



        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                RaisePropertyChanged();
            }
        }

        public RelayCommand TryRegistration { get; }
        public Execute toto { get; private set; }

        private void Try()
        {
            if (Name != null)
                if (Name.Equals("toto"))
                    MessageBox.Show("Good, " + Name + "!");
                else
                    MessageBox.Show("Sorry. You cannot access this page.");
        }

    }
}
