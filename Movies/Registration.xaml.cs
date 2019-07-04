using System.Windows;

namespace Movies
{
    /// <summary>
    /// </summary>
    public partial class Registration : Window
    {
        public PasswordCmd Pass { get; set; }
        public Registration()
        {
            InitializeComponent();
            DataContext = this;
            Pass = new PasswordCmd();
        }
    }
}
